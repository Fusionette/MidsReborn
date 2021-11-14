namespace MidsReborn.Controls
{
    public class pnlGFX : PictureBox
    {
        public pnlGFX()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.DoubleBuffer, true);
        }
    }
}