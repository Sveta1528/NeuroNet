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
            r = g = b = Convert.ToByte(Convert.ToInt32(0.299*r + 0.587*g + 0.114*b));
        }

        public void BitmapToArray(ref Bitmap img, Color background, ref int[] res)
        {
            RGBtoGray(ref img);
            ColorToGray(ref background);
            int w = img.Width, h = img.Height, size = w*h;
            int index = 0;
            for (int y = 0; y < h; ++y)
                for (int x = 0; x < w; ++x)
                {
                    Color color = img.GetPixel(x, y);
                    if (Math.Abs(color.R - background.R) < 10 &
                        Math.Abs(color.G - background.G) < 10 &
                        Math.Abs(color.B - background.B) < 10)
                    {
                        //img.SetPixel(x, y, Color.White);
                        res[index] = -1;
                    }
                    else
                    {
                        //img.SetPixel(x, y, Color.Black);
                        res[index] = 1;
                    }
                    index++;

                }
        }

        public void ArrayToBitmap(ref int[] vec, int w, int h, ref Bitmap res)
        {
            int index = 0;
            for (int y = 0; y < h; ++y)
                for (int x = 0; x < w; ++x)
                {
                    res.SetPixel(x, y, vec[index] == -1 ? Color.White : Color.Black);
                    index++;
                }
        }
    }
}
