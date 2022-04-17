namespace Mids_Reborn.Forms.Controls
{
    internal interface IDrawLock
    {
        public void LockDraw();
        public void UnlockDraw(bool redraw = true);
    }
}