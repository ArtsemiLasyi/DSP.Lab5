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
            int pixelSize = Image.GetPixelFormatSize(fragment.PixelFormat) / 8;

            byte[] fragmentBytes = GetBytes(fragment);
            byte[] originalBytes = GetBytes(original);

            int deltaHeight = original.Height - fragment.Height;
            int deltaWidth = original.Width - fragment.Width;

            int[] sums = new int[deltaHeight * deltaWidth];

            for (int i = 0; i < deltaHeight; i++)
            {
                for (int j = 0; j < deltaWidth * pixelSize; j += pixelSize)
                {
                    for (int s = 0; s < fragment.Height; s++)
                    {
                        for (int k = 0; k < fragment.Width; k += pixelSize)
                        {
                            int index = (i + s) + (j + k);
                            sums[i * deltaHeight + j / pixelSize] += fragmentBytes[index] * originalBytes[index];
                        }
                    }
                }
            }
            
            int max = sums.Max();
            int indexMax = 0;
            for (int i = 0; i < sums.Length; i++)
            {
                if (sums[i] == max)
                {
                    indexMax = i;
                }
            }


            return new Point(indexMax / deltaHeight, indexMax - (indexMax / deltaHeight));
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
