using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace Mids_Reborn.Forms.Controls
{
    [ToolboxBitmap(typeof(ListView))]
    public class SKGLBoostColumns : SKGLControl
    {
        public enum ItemType
        {
            Blank,
            Text,
            Value
        }
        
        public struct BoostItem
        {
            public DataView2.BoostType BoostType;
            public ItemType ItemType;
            public string Text;
            public string ToolTipText;
        }

        private List<List<BoostItem>> Columns;

        [Description("Number of columns to show")]
        [Category("Layout")]
        private int NumColumns;

        [Description("Linked columns (for highlights)")]
        [Category("Layout")]
        public List<List<int>> ColumnLinks = new();

        [Description("Font used to draw items")]
        [Category("Appearance")]
        public SKFont ItemFont;

        public event EventHandler Draw;

        public void ClearItems()
        {
            Columns = new List<List<BoostItem>>();
            for (var i = 0; i < Columns.Count; i++)
            {
                Columns.Add(new List<BoostItem>());
            }
        }

        public void ClearItems(int n)
        {
            NumColumns = n;

            Columns = new List<List<BoostItem>>();
            for (var i = 0; i < Columns.Count; i++)
            {
                Columns.Add(new List<BoostItem>());
            }
        }

        public void ClearItems(int n, List<List<int>> columnLinks)
        {
            NumColumns = n;
            ColumnLinks = columnLinks;

            Columns = new List<List<BoostItem>>();
            for (var i = 0; i < Columns.Count; i++)
            {
                Columns.Add(new List<BoostItem>());
            }
        }

        public void AddItem(BoostItem item, int column)
        {
            if (column < 0 | column > Columns.Count)
            {
                return;
            }

            Columns[column].Add(item);
        }

        public SKGLBoostColumns()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            ClearItems();

            Draw += SKGLBoostColumns_Draw;
            PaintSurface += SKGLBoostColumns_PaintSurface;
        }

        protected void SKGLBoostColumns_Draw(object sender, EventArgs e)
        {
            Invalidate();
        }

        protected void SKGLBoostColumns_PaintSurface(object sender, SKPaintGLSurfaceEventArgs e)
        {
            const int interLine = 3;
            var w = Width - Padding.Right - Padding.Left;
            e.Surface.Canvas.Clear(SKColors.Black);
            for (var c = 0; c < Columns.Count; c++)
            {
                for (var i = 0; i < Columns[c].Count; i++)
                {
                    if (Columns[c][i].ItemType == ItemType.Blank)
                    {
                        continue;
                    }

                    var textPaint = new SKPaint
                    {
                        Color = Columns[c][i].ItemType switch
                        {
                            ItemType.Text => new SKColor(160, 160, 160),
                            ItemType.Value => Columns[c][i].BoostType switch
                            {
                                DataView2.BoostType.Reduction => new SKColor(255, 20, 20),
                                DataView2.BoostType.Enhancement => new SKColor(0, 240, 80),
                                DataView2.BoostType.Extra => new SKColor(0, 220, 220),
                                _ => SKColors.WhiteSmoke,
                            },
                            _ => SKColors.WhiteSmoke
                        }
                    };

                    e.Surface.Canvas.DrawText(
                        SKTextBlob.Create(Columns[c][i].Text, ItemFont),
                        c * w / (float) Columns.Count,
                        Padding.Top + i * (interLine + ItemFont.Size),
                        textPaint
                    );
                }
            }
        }
    }
}