using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Mids_Reborn.Forms.Controls
{
    public partial class DV2TotalsPane : UserControl, IDrawLock
    {
        private List<Item> Items = new();
        private const int BarHeight = 10;
        private const float LabelsFontSize = 7;
        private int HoveredBar = -1;
        private bool _DrawLock;

        [Description("Maximum visible items")]
        [Category("Data")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        [DefaultValue(6)]
        public int MaxItems { get; set; }

        [Description("Maximum global bar value")]
        [Category("Data")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        [DefaultValue(100)]
        public float GlobalMaxValue { get; set; }

        [Description("Bars background gradient end color")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public Color BackgroundColorEnd { get; set; }

        [Description("Bars color (main value)")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public Color BarColorMain { get; set; }

        [Description("Bars color (uncapped value)")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public Color BarColorUncapped { get; set; }

        [Description("Highlighted item background color")]
        [Category("Appearance")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public Color HighlightBackgroundColor { get; set; }

        [Description("Enable uncapped values (dual bars)")]
        [Category("Data")]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [NotifyParentProperty(true)]
        public bool EnableUncappedValues { get; set; }

        public delegate void BarHoverEventHandler(int barIndex, string label, float value, float uncappedValue);
        
        [Description("Occurs when the mouse pointer is over one of the bars")]
        public event BarHoverEventHandler BarHover;

        public DV2TotalsPane()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            Load += DV2TotalsPane_Load;
            Resize += DV2TotalsPane_Resize;

            InitializeComponent();
            
            skglControl1.PaintSurface += skglControl1_PaintSurface;
            skglControl1.MouseLeave += skglControl1_MouseLeave;
            skglControl1.MouseMove += skglControl1_MouseMove;
        }

        public void LockDraw()
        {
            _DrawLock = true;
        }

        public void UnlockDraw(bool redraw = true)
        {
            _DrawLock = false;
            if (!redraw)
            {
                return;
            }

            Draw();
        }

        public void ClearItems(bool redraw = false)
        {
            Items.Clear();
            if (!redraw | _DrawLock)
            {
                return;
            }

            Draw();
        }

        public void AddItem(Item item, bool redraw = false)
        {
            Items.Add(item);
            if (!redraw | _DrawLock)
            {
                return;
            }

            Draw();
        }

        private static SKColor FromColor(Color c)
        {
            return new SKColor(c.R, c.G, c.B);
        }

        public void Draw()
        {
            if (_DrawLock)
            {
                return;
            }

            skglControl1.Invalidate();
        }

        private void DrawOutlineText(SKCanvas canvas, string text, SKPoint location, SKColor textColor, float fontSize = 12f, float strokeWidth = 5f)
        {
            using var textFont = new SKFont(SKTypeface.Default, fontSize);
            using var textPaint = new SKPaint(textFont)
            {
                IsAntialias = true,
                IsStroke = false,
                Color = textColor
            };

            var textBounds = new SKRect();
            textPaint.MeasureText(text, ref textBounds);

            using var textPath = textPaint.GetTextPath(text, location.X, location.Y); // ??? - centered text not handled
            using var outlinePath = new SKPath();
            textPaint.GetFillPath(textPath, outlinePath);

            using var outlinePaint = new SKPaint
            {
                StrokeCap = SKStrokeCap.Round,
                StrokeMiter = 0, /* Avoid spikes artifacts around sharp edges */
                Style = SKPaintStyle.Stroke,
                StrokeWidth = strokeWidth,
                Color = SKColors.Black
            };

            canvas.DrawPath(outlinePath, outlinePaint);
            canvas.DrawText(text, location, textPaint);
        }

        private void DV2TotalsPane_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void DV2TotalsPane_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void skglControl1_PaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {
            const float barWidthFactor = 0.6f;

            e.Surface.Canvas.Clear(SKColors.Black);

            using var bgGradientPaint = new SKPaint
            {
                Shader = SKShader.CreateLinearGradient(
                    new SKPoint(0, 0), new SKPoint(Width, 0),
                    new[] { SKColors.Black, SKColors.Black, FromColor(BackgroundColorEnd) },
                    new[] { 0, 1 - barWidthFactor, 1 },
                    SKShaderTileMode.Clamp
                )
            };

            e.Surface.Canvas.DrawRect(new SKRect(0, 0, Width, Height), bgGradientPaint);

            using var barBg = new SKPaint { Color = SKColors.Black };
            using var linePaint = new SKPaint { Color = SKColors.DarkRed };
            using var barUncapped = new SKPaint { Color = FromColor(BarColorUncapped) };
            using var textPaint = new SKPaint { Color = SKColors.WhiteSmoke };
            using var outlinePaint = new SKPaint { Color = SKColors.Black };

            var xStart = (int) Math.Round(Width * (1 - barWidthFactor)) - 2;
            var globalMaxValue = GlobalMaxValue < float.Epsilon ? 100 : GlobalMaxValue;
            for (var i = 0; i < Math.Min(Items.Count, MaxItems); i++)
            {
                var scale = (Width - 1) * barWidthFactor / globalMaxValue;
                var barGradientPaint = new SKPaint
                {
                    Shader = SKShader.CreateLinearGradient(
                        new SKPoint(xStart + 1, 0), new SKPoint(xStart + 1 + Items[i].Value * scale, 0),
                        new[] { new SKColor((byte)Math.Round(BarColorMain.R / 4f), (byte)Math.Round(BarColorMain.G / 4f), (byte)Math.Round(BarColorMain.R / 4f)), FromColor(BarColorMain) },
                        new[] { 0, 1f },
                        SKShaderTileMode.Clamp
                    )
                };

                if (EnableUncappedValues)
                {
                    e.Surface.Canvas.DrawRect(new SKRect(xStart, i * 12 + 2, xStart + 2 + Items[i].UncappedValue * scale, i * 12 + 13), barBg);
                    if (Math.Abs(Items[i].UncappedValue - Items[i].Value) > float.Epsilon)
                    {
                        e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].UncappedValue * scale, i * 12 + 12), barUncapped);
                    }

                    e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].Value * scale, i * 12 + 12), barGradientPaint);

                    if (Math.Abs(Items[i].UncappedValue - Items[i].Value) > float.Epsilon)
                    {
                        e.Surface.Canvas.DrawLine(new SKPoint(xStart + 2 + Items[i].Value * scale, i * 12 + 2), new SKPoint(xStart + 2 + Items[i].Value * scale, i * 12 + 13), linePaint);
                    }
                }
                else
                {
                    e.Surface.Canvas.DrawRect(new SKRect(xStart, i * 12 + 2, xStart + 2 + Items[i].Value * scale, i * 12 + 13), barBg);
                    //e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].UncappedValue * scale, i * 12 + 12), barUncapped);
                    e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].Value * scale, i * 12 + 12), barGradientPaint);
                }

                //e.Surface.Canvas.DrawText(Items[i].Name, new SKPoint(2, i * 12 + 4), textPaint);
                DrawOutlineText(e.Surface.Canvas, Items[i].Name, new SKPoint(2, i * 12 + 7 + LabelsFontSize / 2f), SKColors.WhiteSmoke);
            }
        }

        #region Table label sub-class

        public class Item
        {
            private readonly float _Value;
            private readonly float _UncappedValue;

            public string Name { get; set; }
            public float Value => DisplayPercentage ? _Value * 100 : _Value;
            public float UncappedValue => DisplayPercentage ? _UncappedValue * 100 : _UncappedValue;
            public bool DisplayPercentage { get; set; }

            public Item(string name, float value, float uncappedValue, bool displayPercentage)
            {
                Name = name;
                _Value = value;
                _UncappedValue = uncappedValue;
                DisplayPercentage = displayPercentage;
            }
        }

        #endregion

        #region Event handlers

        private void skglControl1_MouseLeave(object sender, EventArgs e)
        {
            HoveredBar = -1;
            skglControl1.Invalidate();

            BarHover?.Invoke(-1, "", 0, 0);
        }

        #endregion

        private void skglControl1_MouseMove(object sender, MouseEventArgs e)
        {
            BarHover?.Invoke(HoveredBar, Items[HoveredBar].Name, Items[HoveredBar].Value, Items[HoveredBar].UncappedValue);
        }
    }
}