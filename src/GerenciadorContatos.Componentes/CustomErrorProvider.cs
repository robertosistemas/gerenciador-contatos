using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorContatos.Componentes
{
    /// <summary>
    /// https://www.cyotek.com/blog/creating-a-custom-errorprovider-component-for-use-with-windows-forms-applications
    /// </summary>
    [ProvideProperty("ErrorBackColor", typeof(Control)), ProvideProperty("Error", typeof(Control))]
    public partial class CustomErrorProvider : Component, IExtenderProvider
    {

        private readonly IDictionary<Control, Color> _errorColors;
        private readonly IDictionary<Control, string> _errorTexts;
        private readonly IList<Control> _erroredControls;
        private readonly IDictionary<Control, Color> _originalColors;
        private readonly System.Windows.Forms.ToolTip _toolTip;
        private Color _defaultErrorColor;

        public CustomErrorProvider() : this(null)
        {
            //InitializeComponent();
        }

        public CustomErrorProvider(IContainer container)
        {
            if (container != null)
                container.Add(this);

            InitializeComponent();

            DefaultErrorColor = Color.FromArgb(255, 255, 220, 220);
            _erroredControls = new List<Control>();
            _originalColors = new Dictionary<Control, Color>();
            _errorColors = new Dictionary<Control, Color>();
            _errorTexts = new Dictionary<Control, string>();
            _toolTip = new System.Windows.Forms.ToolTip();
        }

        #region Events

        /// <summary>
        ///   Occurs when the DefaultErrorColor property value changes
        /// </summary>
        [Category("Property Changed")]
        public event EventHandler DefaultErrorColorChanged;

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets the default error background color.
        /// </summary>
        /// <value>The default color of the error.</value>
        [Category("Appearance"), DefaultValue(typeof(Color), "255, 255, 220, 220")]
        public Color DefaultErrorColor
        {
            get { return _defaultErrorColor; }
            set
            {
                if (DefaultErrorColor != value)
                {
                    _defaultErrorColor = value;

                    OnDefaultErrorColorChanged(EventArgs.Empty);
                }
            }
        }

        public bool HasErrors
        {
            get { return _erroredControls.Count != 0; }
        }

        /// <summary>
        ///   Gets or sets an object that contains data about the component.
        /// </summary>
        /// <value>An object that contains data about the control. The default is null.</value>
        [Category("Data"), DefaultValue((string)null), TypeConverter(typeof(StringConverter))]
        public object Tag { get; set; }

        #endregion

        #region Members

        /// <summary>
        ///   Clears any error associated with the given control
        /// </summary>
        /// <param name="control">The control.</param>
        public void ClearError(Control control)
        {

            if (_originalColors.TryGetValue(control, out Color originalColor))
                control.BackColor = originalColor;

            _errorTexts.Remove(control);
            _toolTip.SetToolTip(control, null);
            _erroredControls.Remove(control);
        }

        /// <summary>
        ///   Clears all errors
        /// </summary>
        public void ClearErrors()
        {
            foreach (KeyValuePair<Control, Color> pair in _originalColors)
                pair.Key.BackColor = pair.Value;

            _errorTexts.Clear();
            _toolTip.RemoveAll();
            _erroredControls.Clear();
        }

        /// <summary>
        ///   Returns the current error description string for the specified control.
        /// </summary>
        /// <param name="control">The item to get the error description string for.</param>
        /// <returns>The error description string for the specified control.</returns>
        /// <exception cref="System.ArgumentNullException">
        ///   <c>control</c> is null.
        /// </exception>
        [Category("Appearance"), DefaultValue("")]
        public string GetError(Control control)
        {

            if (control == null)
                throw new ArgumentNullException(nameof(control));

            if (!_errorTexts.TryGetValue(control, out string result))
                result = string.Empty;

            return result;
        }

        /// <summary>
        ///   Returns the error background color for the specified control.
        /// </summary>
        /// <param name="control">The item to get the error background color for.</param>
        /// <returns>The error background color for the specified control.</returns>
        /// <exception cref="System.ArgumentNullException">
        ///   <c>control</c> is null.
        /// </exception>
        [Category("Appearance"), DefaultValue(typeof(Color), "255, 255, 220, 220")]
        public Color GetErrorBackColor(Control control)
        {

            if (!_errorColors.TryGetValue(control, out Color result))
                result = DefaultErrorColor;

            return result;
        }

        /// <summary>
        ///   Sets the error description string for the specified control.
        /// </summary>
        /// <param name="control">The control to set the error description string for.</param>
        /// <param name="value">The error description string, or null or Empty to remove the error.</param>
        /// <exception cref="System.ArgumentNullException">
        ///   <c>control</c> is null.
        /// </exception>
        public void SetError(Control control, string value)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control));

            if (value == null)
                value = string.Empty;

            if (!string.IsNullOrEmpty(value))
            {
                _errorTexts[control] = value;

                ShowError(control);
            }
            else
                ClearError(control);
        }

        /// <summary>
        ///   Sets the error background colour for the specified control.
        /// </summary>
        /// <param name="control">The control to set the error background color for.</param>
        /// <param name="value">The error background color.</param>
        /// <exception cref="System.ArgumentNullException">
        ///   <c>control</c> is null.
        /// </exception>
        public void SetErrorBackColor(Control control, Color value)
        {
            _originalColors[control] = control.BackColor;
            _errorColors[control] = value;
        }

        /// <summary>
        ///   Raises the <see cref="DefaultErrorColorChanged" /> event.
        /// </summary>
        /// <param name="e">
        ///   The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        protected virtual void OnDefaultErrorColorChanged(EventArgs e)
        {
            EventHandler handler;

            handler = DefaultErrorColorChanged;

            handler?.Invoke(this, e);
        }

        /// <summary>
        ///   Shows error information for the specified control
        /// </summary>
        /// <param name="control">The control to display error information for.</param>
        /// <exception cref="System.ArgumentNullException">
        ///   <c>control</c> is null.
        /// </exception>
        protected virtual void ShowError(Control control)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control));

            if (!_originalColors.ContainsKey(control))
                _originalColors.Add(control, control.BackColor);

            control.BackColor = GetErrorBackColor(control);
            _toolTip.SetToolTip(control, GetError(control));

            if (!_erroredControls.Contains(control))
                _erroredControls.Add(control);
        }

        #endregion

        #region IExtenderProvider Members

        /// <summary>
        ///   Specifies whether this object can provide its extender properties to the specified object.
        /// </summary>
        /// <param name="extendee">
        ///   The <see cref="T:System.Object" /> to receive the extender properties.
        /// </param>
        /// <returns>true if this object can provide extender properties to the specified object; otherwise, false.</returns>
        bool IExtenderProvider.CanExtend(object extendee)
        {
            return extendee is Control;
        }

        #endregion
    }
}
