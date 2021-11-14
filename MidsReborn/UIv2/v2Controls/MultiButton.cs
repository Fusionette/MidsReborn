#nullable enable
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Mids_Reborn.UIv2.v2Controls
{
    public partial class MultiButton : Button
    {
        [Description("The style to be used for the button.")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(ButtonStyle.Normal)]
        public ButtonStyle Appearance { get; set; }

        [Description("The font to be used for the button text")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new Font Font { get; set; } = new Font("Arial", 8.25f);

        [Description("The color of the button text.")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new Color ForeColor { get; set; } = Color.Black;


        //Toggle Properties


        [Description("The images to be used when toggling the button.")]
        [Category("Toggle Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [SettingsBindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public ToggleButtonImages Images { get; set; } = new ToggleButtonImages();

        [Description("Indicates wether the button has been toggled.")]
        [Category("Toggle Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [SettingsBindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool Toggled
        {
            get
            {
                var value = ToggleState switch
                {
                    ToggledState.Off => false,
                    ToggledState.On => true,
                    _ => false
                };

                return value;
            }
            set
            {
                ToggleState = value switch
                {
                    false => ToggledState.Off,
                    true => ToggledState.On
                };
            }
        }

        private ToggledState ToggleState { get; set; }

        //Events
        [Browsable(true)]
        [Category("Toggle")]
        public event EventHandler<bool> ToggleChangedEvent;


        //Constructor
        public MultiButton()
        {
            ToggleChangedEvent += ToggleChanged;
            Toggled = false;
            ToggleState = ToggledState.Off;
            InitializeComponent();
        }

        //Methods
        private void ToggleChanged(object? sender, bool e)
        {
            switch (e)
            {
                case false:
                    BackgroundImage = Images.ToggleOff;
                    Invalidate();
                    break;
                case true:
                    BackgroundImage = Images.ToggleOn;
                    Invalidate();
                    break;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if (Appearance is ButtonStyle.Toggle)
            {
                base.OnClick(e);
                ToggleChangedEvent?.Invoke(this, Toggled);
            }
            else
            {
                base.OnClick(e);
            }
        }


        //Classes
        public enum ButtonStyle
        {
            Normal,
            Toggle,
        }

        public enum ToggledState
        {
            Off,
            On
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ToggleButtonImages
        {
            [Browsable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public Image? ToggleOn { get; set; }

            [Browsable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public Image? ToggleOff { get; set; }
        }
    }
}
