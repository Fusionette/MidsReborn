using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace MidsReborn.Controls
{
    public sealed partial class MultiButton : Button
    {
        //Properties
        [Browsable(false)] public sealed override Color BackColor { get; set; } = Color.Transparent;
        [Browsable(false)] public override Image? BackgroundImage { get; set; }
        [Browsable(false)] public override ImageLayout BackgroundImageLayout { get; set; }
        [Browsable(false)] public new string Text { get; set; } = string.Empty;


        private ToggledState ToggleState { get; set; }
        private string _displayText = string.Empty;
        
        [Description("The font used to display text in the control.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new Font Font { get; set; } = DefaultFont;

        [Description("The style of button to be used.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(ButtonStyle.Normal)]
        public ButtonStyle Style { get; set; }

        [Description("The text associated with the control.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public string DisplayText
        {
            get
            {
                if (!Outline.Enabled)
                {
                    _displayText = Text;
                }

                return _displayText;
            }
            set
            {
                _displayText = value;
                if (!Outline.Enabled)
                {
                    Text = _displayText;
                }
            }
        }

        [Description("The alignment of the text that will be displayed on the control.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public override ContentAlignment TextAlign { get; set; } = ContentAlignment.MiddleCenter;

        [Description("Indicates whether the text should be outlined or not.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public TextOutline Outline { get; set; } = new();

        [Description("The images to be used by the control when in toggle mode.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [SettingsBindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public ToggleButtonImages ToggleImages { get; set; } = new();

        [Description("The text to be used by the control when in toggle mode.")]
        [Category("MultiButton Settings")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [SettingsBindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public ToggleButtonText ToggleText { get; set; } = new();

        [Description("Indicates whether the button has been toggled.")]
        [Category("MultiButton Settings")]
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

        //Events
        [Browsable(true)]
        [Category("Toggle")]
        public event EventHandler<bool> ToggleChangedEvent;

        //Constructor
        public MultiButton()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.Opaque | ControlStyles.ResizeRedraw, true);
            //BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            // Toggled = false;
            // ToggleState = ToggledState.Off;
            Click += Clicked;
            ToggleChangedEvent += ToggleChanged;
            InitializeComponent();
        }

        //Methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (Outline.Enabled)
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                pevent.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                var textSize = TextRenderer.MeasureText(DisplayText, Font);
                var emSize = Font.SizeInPoints * (Font.FontFamily.GetCellAscent(Font.Style) + Font.FontFamily.GetCellDescent(Font.Style)) / Font.FontFamily.GetEmHeight(Font.Style);
                using var path = new GraphicsPath();
                using var outline = new Pen(Outline.Color, Outline.Width) { LineJoin = LineJoin.Round };
                using var sf = new StringFormat(StringFormatFlags.NoClip | StringFormatFlags.NoWrap);
                switch (TextAlign)
                {
                    case ContentAlignment.TopLeft:
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.TopCenter:
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.TopRight:
                        sf.Alignment = StringAlignment.Near;
                        sf.LineAlignment = StringAlignment.Far;
                        break;
                    case ContentAlignment.MiddleLeft:
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.MiddleCenter:
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.MiddleRight:
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Far;
                        break;
                    case ContentAlignment.BottomLeft:
                        sf.Alignment = StringAlignment.Far;
                        sf.LineAlignment = StringAlignment.Near;
                        break;
                    case ContentAlignment.BottomCenter:
                        sf.Alignment = StringAlignment.Far;
                        sf.LineAlignment = StringAlignment.Center;
                        break;
                    case ContentAlignment.BottomRight:
                        sf.Alignment = StringAlignment.Far;
                        sf.LineAlignment = StringAlignment.Far;
                        break;
                }

                var controlBounds = new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - textSize.Width / 2, ClientRectangle.Height - textSize.Height / 2);
                using Brush foreBrush = new SolidBrush(ForeColor);
                path.AddString(DisplayText, Font.FontFamily, (int)Font.Style, emSize, controlBounds, sf);
                pevent.Graphics.ScaleTransform(1.3f, 1.35f);
                pevent.Graphics.DrawPath(outline, path);
                pevent.Graphics.FillPath(foreBrush, path);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (Style == ButtonStyle.Toggle)
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                pevent.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
                if (BackgroundImage != null)
                {
                    pevent.Graphics.DrawImage(BackgroundImage, ClientRectangle);
                }
            }
            else
            {
                base.OnPaint(pevent);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TRANSPARENT = 0x20;
                var createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TRANSPARENT;
                return createParams;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private void Clicked(object? sender, EventArgs e)
        {
            if (Style == ButtonStyle.Toggle)
            {
                if (!Toggled)
                {
                    Toggled = true;
                    ToggleState = ToggledState.On;
                    ToggleChangedEvent?.Invoke(this, Toggled);
                }
                else
                {
                    Toggled = false;
                    ToggleState = ToggledState.Off;
                    ToggleChangedEvent?.Invoke(this, Toggled);
                }
            }
        }

        private void ToggleChanged(object? sender, bool e)
        {
            switch (e)
            {
                case false:
                    Invalidate();
                    DisplayText = ToggleText.ToggleOff;
                    BackgroundImage = ToggleImages.ToggleOff;
                    break;
                case true:
                    Invalidate();
                    DisplayText = ToggleText.ToggleOn;
                    BackgroundImage = ToggleImages.ToggleOn;
                    break;
            }
        }

        //Enums
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

        //Classes
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ToggleButtonImages
        {
            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public Image? ToggleOn { get; set; }

            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public Image? ToggleOff { get; set; }
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class ToggleButtonText
        {
            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public string ToggleOn { get; set; } = string.Empty;

            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public string ToggleOff { get; set; } = string.Empty;
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public class TextOutline
        {
            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public bool Enabled { get; set; }

            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public Color Color { get; set; } = Color.Black;

            [Browsable(true), Bindable(true), NotifyParentProperty(true), EditorBrowsable(EditorBrowsableState.Always)]
            public int Width { get; set; } = 2;
        }
    }
}
