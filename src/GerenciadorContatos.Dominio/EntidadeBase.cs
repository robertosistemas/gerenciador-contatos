using GerenciadorContatos.Dominio.Abstracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GerenciadorContatos.Dominio
{
    public class EntidadeBase<TEntity, TKey> : IEntidade<TKey>, INotifyPropertyChanged, IEditableObject
    {

        private static object _lockObject = new object();

        private TKey _id;

        public virtual TKey Id
        {
            get { return _id; }
            set { SetField(ref _id, value); }
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private TEntity Cache;

        private object CurrentModel
        {
            get { return this; }
        }

        private bool EmEdicao = false;

        public void BeginEdit()
        {
            if (!EmEdicao)
            {
                lock (_lockObject)
                {
                    if (!EmEdicao)
                    {
                        EmEdicao = true;
                        Cache = Activator.CreateInstance<TEntity>();

                        foreach (var info in CurrentModel.GetType().GetProperties())
                        {
                            if (!info.CanRead || !info.CanWrite) continue;
                            var oldValue = info.GetValue(CurrentModel, null);
                            Cache.GetType().GetProperty(info.Name).SetValue(Cache, oldValue, null);
                        }
                    }
                }
            }
        }

        public void EndEdit()
        {
            if (EmEdicao)
            {
                lock (_lockObject)
                {
                    if (EmEdicao)
                    {
                        EmEdicao = false;
                        Cache = default;
                    }
                }
            }
        }

        public void CancelEdit()
        {
            if (EmEdicao)
            {
                lock (_lockObject)
                {
                    if (EmEdicao)
                    {
                        EmEdicao = false;
                        foreach (var info in CurrentModel.GetType().GetProperties())
                        {
                            if (!info.CanRead || !info.CanWrite) continue;
                            var oldValue = info.GetValue(Cache, null);
                            CurrentModel.GetType().GetProperty(info.Name).SetValue(CurrentModel, oldValue, null);
                        }
                    }
                }
            }
        }
    }
}
