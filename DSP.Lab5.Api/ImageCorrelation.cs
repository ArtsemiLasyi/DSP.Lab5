using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace DSP.Lab5.Api
{
    public static class ImageCorrelation 
    {
        public static Point GetCoincidencePoint(Bitmap fragment, Bitmap original)
        {
            int maxY = 0;
            int maxX = 0;

            int fragmentPixelSize = Image.GetPixelFormatSize(fragment.PixelFormat) / 8;
            int originalPixelSize = Image.GetPixelFormatSize(original.PixelFormat) / 8;

            byte[] fragmentBytes = GetBytes(fragment);


            return new Point(maxX, maxY);
        }

        public static byte[] GetBytes(Bitmap bitmap)
        {
            BitmapData fragmentBitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadOnly,
                bitmap.PixelFormat
            );

            int fragmentBytes = fragmentBitmapData.Stride * fragmentBitmapData.Height;
            IntPtr scan = fragmentBitmapData.Scan0;
            byte[] data = new byte[fragmentBytes];
            Marshal.Copy(scan, data, 0, fragmentBytes);

            bitmap.UnlockBits(fragmentBitmapData);
            return data;
        }
    }
}
