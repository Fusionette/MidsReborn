using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mids_Reborn.Forms.Controls
{
    public static class DataGridViewExt
    {
        public static void SetCellContent(this DataGridView target, int row, int column)
        {
            target.Rows[row].Cells[column].Style.Font = new Font(new FontFamily("Microsoft Sans Serif"), 12, FontStyle.Regular, GraphicsUnit.Pixel);
            target.Rows[row].Cells[column].Style.ForeColor = Color.WhiteSmoke;
            target.Rows[row].Cells[column].Style.BackColor = Color.Black;
            target.Rows[row].Cells[column].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            target.Rows[row].Cells[column].Value = string.Empty;
        }

        public static void SetCellContent(this DataGridView target, string text, string tooltipText, int row, int column)
        {
            target.Rows[row].Cells[column].Style.Font = new Font(new FontFamily("Microsoft Sans Serif"), 12, FontStyle.Regular, GraphicsUnit.Pixel);
            target.Rows[row].Cells[column].Style.ForeColor = Color.WhiteSmoke;
            target.Rows[row].Cells[column].Style.BackColor = Color.Black;
            target.Rows[row].Cells[column].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            target.Rows[row].Cells[column].Value = text;
            if (tooltipText != "")
            {
                target.Rows[row].Cells[column].ToolTipText = tooltipText;
            }
        }

        public static void SetCellContent(this DataGridView target, string text, Color textColor, string tooltipText, int row, int column)
        {
            target.Rows[row].Cells[column].Style.Font = new Font(new FontFamily("Microsoft Sans Serif"), 12, FontStyle.Regular, GraphicsUnit.Pixel);
            target.Rows[row].Cells[column].Style.ForeColor = textColor;
            target.Rows[row].Cells[column].Style.BackColor = Color.Black;
            target.Rows[row].Cells[column].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            target.Rows[row].Cells[column].Value = text;
            if (tooltipText != "")
            {
                target.Rows[row].Cells[column].ToolTipText = tooltipText;
            }
        }

        public static void BlankCells(this DataGridView target, int rows, int rowHeight = 0)
        {
            if (rowHeight == 0)
            {
                rowHeight = (int) Math.Round(target.Height / (decimal) rows);
            }

            target.Rows.Clear();
            for (var i = 0; i < rows; i++)
            {
                target.Rows.Add();
                target.Rows[i].Height = rowHeight;

                for (var j = 0; j < target.Columns.Count; j++)
                {
                    target.SetCellContent(i, j);
                }
            }
        }
    }
}
