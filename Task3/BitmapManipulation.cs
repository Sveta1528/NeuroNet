using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task3
{
    class BitmapManipulation
    {


        private void RGBtoGray(ref Bitmap img)
        {
            for (int x = 0; x < img.Width; ++x)
                for (int y = 0; y < img.Height; ++y)
                {
                    Color c = img.GetPixel(x, y);
                    ColorToGray(ref c);
                    img.SetPixel(x, y, c);
                }
        }

        private void ColorToGray(ref Color c)
        {
            Byte r = c.R, g = c.G, b = c.B;
            r = g = b = Convert.ToByte(Convert.ToInt32(0.299*r + 0.587*g + 0.114*b));
        }

        public double[] BitmapToArray(ref Bitmap img, Color background)
        {
            RGBtoGray(ref img);
            ColorToGray(ref background);
            int w = img.Width, h = img.Height, size = w*h;
            int module = 30;
            double[] result = new double[h];
            for (int y = 0; y < h; ++y)
            {
                var sum = 0;
                for (int x = 0; x < w; ++x)
                {
                    Color color = img.GetPixel(x, y);
                    if (!(Math.Abs(color.R - background.R) < module &
                          Math.Abs(color.G - background.G) < module &
                          Math.Abs(color.B - background.B) < module)
                    )
                        sum++;
                }
                result[y] = sum;
            }
            return result;
        }

        public double[] BitmapToArray2(ref Bitmap img, Color background)
        {
            RGBtoGray(ref img);
            ColorToGray(ref background);
            int w = img.Width, h = img.Height, size = w * h;
            int module = 30;
            double[] result = new double[h*w];
            int index = 0;
            for (int y = 0; y < h; ++y)
            for (int x = 0; x < w; ++x)
            {
                Color color = img.GetPixel(x, y);
                if (!(Math.Abs(color.R - background.R) < module &
                      Math.Abs(color.G - background.G) < module &
                      Math.Abs(color.B - background.B) < module)
                )
                    result[index] = 1;
                else
                    result[index] = 0;
                index++;
            }
            return result;
        }


    }
}
