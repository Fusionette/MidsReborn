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
        private int VisibleItemsCount => Math.Min(Items.Count, MaxItems);
        private const int BarHeight = 10;
        private const float LabelsFontSize = 7;
        private bool _DrawLock;

        [Description("Maximum visible items"), Category("Data"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MaxItems;

        [Description("Maximum global bar value"), Category("Data"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float GlobalMaxValue;

        [Description("Bars background gradient end color"), Category("Appearance"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColorEnd;

        [Description("Bars color (main value)"), Category("Appearance"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BarColorMain;

        [Description("Bars color (uncapped value)"), Category("Appearance"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BarColorUncapped;

        [Description("Enable uncapped values (dual bars)"), Category("Data"),
         Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool EnableUncappedValues;

        public DV2TotalsPane()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            Load += DV2TotalsPane_Load;
            Resize += DV2TotalsPane_Resize;

            InitializeComponent();
            skglControl1.PaintSurface += skglControl1_PaintSurface;
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
            if (!redraw)
            {
                return;
            }

            Draw();
        }

        public void AddItem(Item item, bool redraw = false)
        {
            Items.Add(item);
            if (!redraw)
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
            const float barWidthFactor = 0.333f;

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
            using var barUncapped = new SKPaint { Color = FromColor(BarColorUncapped) };
            using var textPaint = new SKPaint { Color = SKColors.WhiteSmoke };
            using var outlinePaint = new SKPaint { Color = SKColors.Black };

            var xStart = (int) Math.Round(Width / (1 - barWidthFactor)) - 2;
            for (var i = 0; i < Math.Min(Items.Count, VisibleItemsCount); i++)
            {
                var barGradientPaint = new SKPaint
                {
                    Shader = SKShader.CreateLinearGradient(
                        new SKPoint(xStart + 1, 0), new SKPoint(Width, 0),
                        new[] { new SKColor((byte) Math.Round(BarColorMain.R / 4f), (byte) Math.Round(BarColorMain.G / 4f), (byte) Math.Round(BarColorMain.R / 4f)), FromColor(BarColorMain) }, // ???
                        new[] { 0, 1f },
                        SKShaderTileMode.Clamp
                    )
                };

                if (EnableUncappedValues)
                {
                    var scale = Math.Max(Items[i].Value, Items[i].UncappedValue) / GlobalMaxValue * ((Width - 1) * barWidthFactor);
                    e.Surface.Canvas.DrawRect(new SKRect(xStart, i * 12 + 2, Width - 2, i * 12 + 12), barBg);
                    e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].UncappedValue * scale, i * 12 + 12), barUncapped);
                    e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].Value * scale, i * 12 + 12), barGradientPaint);
                }
                else
                {
                    var scale = Items[i].Value / GlobalMaxValue * ((Width - 1) * barWidthFactor);
                    e.Surface.Canvas.DrawRect(new SKRect(xStart, i * 12 + 2, Width - 2, i * 12 + 12), barBg);
                    //e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].UncappedValue * scale, i * 12 + 12), barUncapped);
                    e.Surface.Canvas.DrawRect(new SKRect(xStart + 1, i * 12 + 3, xStart + 1 + Items[i].Value * scale, i * 12 + 12), barGradientPaint);
                }

                //e.Surface.Canvas.DrawText(Items[i].Name, new SKPoint(2, i * 12 + 4), textPaint);
                DrawOutlineText(e.Surface.Canvas, Items[i].Name, new SKPoint(2, i * 12 + 4), SKColors.WhiteSmoke);
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
    }
}