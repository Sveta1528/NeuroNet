using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1
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
            r = g = b = Convert.ToByte(Convert.ToInt32(0.299 * r + 0.587 * g + 0.114 * b));
        }

        public void WithoutInterval(ref Bitmap img, Color background)
        {
            RGBtoGray(ref img);
            ColorToGray(ref background);
            int w = img.Width, h = img.Height, size = w*h;
            int[] vec = new int[size];
            int index = 0;
            for (int y = 0; y <h; ++y)
                for (int x = 0; x < w; ++x)
                {
                    Color color = img.GetPixel(x, y);
                    if (Math.Abs(color.R - background.R) < 10 &
                        Math.Abs(color.G - background.G) < 10 &
                        Math.Abs(color.B - background.B) < 10)
                    {
                        img.SetPixel(x, y, Color.White);
                        vec[index] = -1;
                    }
                    else
                    {
                        img.SetPixel(x, y, Color.Black);
                        vec[index] = 1;
                    }
                    index++;

                }
        }


    }
}
