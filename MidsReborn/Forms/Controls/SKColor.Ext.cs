using System;
using System.Drawing;
using SkiaSharp;

namespace Mids_Reborn.Forms.Controls
{
    public static class SKColorExt
    {
        public static SKColor FromColor(this SKColor skc, Color c)
        {
            return new SKColor(c.R, c.G, c.B, c.A);
        }

        public static SKColor AddAlpha(this SKColor skc, Color c, byte alpha)
        {
            return new SKColor(c.R, c.G, c.B, alpha);
        }

        public static SKColor AddAlpha(this SKColor skc, byte alpha)
        {
            return new SKColor(skc.Red, skc.Green, skc.Blue, alpha);
        }

        public static SKColor Multiply(this SKColor skc, float factor, bool multiplyAlpha = false)
        {
            return new SKColor(
                (byte) Math.Round(skc.Red * factor),
                (byte) Math.Round(skc.Green * factor),
                (byte) Math.Round(skc.Blue * factor),
                multiplyAlpha ? (byte) Math.Round(skc.Alpha * factor) : skc.Alpha);
        }
    }
}