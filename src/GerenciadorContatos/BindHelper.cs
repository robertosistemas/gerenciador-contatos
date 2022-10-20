using System.Windows.Forms;

namespace GerenciadorContatos
{
    public static class BindHelper
    {
        public static void ClearDataSource(ListControl listControl, object dataSource)
        {
            if (dataSource is BindingSource bindingSource)
                SuspendBinding(bindingSource);
            listControl.ValueMember = null;
            listControl.DisplayMember = null;
            listControl.DataSource = null;
        }

        public static void SetDataSource(ListControl listControl, string valueMember, string displayMember, object dataSource)
        {
            listControl.ValueMember = valueMember;
            listControl.DisplayMember = displayMember;
            listControl.DataSource = dataSource;
            if (dataSource is BindingSource bindingSource)
                ResumeBinding(bindingSource);
        }

        public static void SuspendBinding(BindingSource bindingSource)
        {
            bindingSource.SuspendBinding();
            bindingSource.RaiseListChangedEvents = false;
        }

        public static void ResumeBinding(BindingSource bindingSource)
        {
            bindingSource.ResumeBinding();
            bindingSource.RaiseListChangedEvents = true;
            bindingSource.ResetBindings(false);
        }
    }
}
