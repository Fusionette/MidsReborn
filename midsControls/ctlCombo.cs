using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midsControls
{
    public partial class ctlCombo : ComboBox
    {
        public ImageList ImageList { get; set; }

        public ctlCombo()
        {
            InitializeComponent();
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawVariable;
            DrawItem += combobox_DrawItem;
        }

        protected void combobox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Color foreColor = e.ForeColor;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (e.State.HasFlag(DrawItemState.Focus) && !e.State.HasFlag(DrawItemState.ComboBoxEdit))
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
            }
            else
            {
                using Brush backgBrush = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(backgBrush, e.Bounds);
                foreColor = Color.Black;
            }

            TextRenderer.DrawText(e.Graphics, Items[e.Index].ToString(), e.Font, new Point(e.Bounds.Height + 10, e.Bounds.Y), foreColor);
            e.Graphics.DrawImage(ImageList.Images[e.Index], new Rectangle(e.Bounds.Location, new Size(e.Bounds.Height, e.Bounds.Height)));
        }
    }
}
