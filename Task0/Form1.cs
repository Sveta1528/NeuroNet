using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework.Forms;

namespace Task0
{
    public partial class Form1 : MetroForm
    {
        private Bitmap image;
        private Color _background = Color.Empty;
        private bool _interval = false;
        private int _from, _to;

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName == "")
                    return;
                image = new Bitmap(openFileDialog1.FileName);
                InputPicture.Image = image;
            }
        }

        private void InputPicture_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = image.GetPixel(e.X, e.Y);
            _background = color;
            CurrentColor.BackColor = color;
            if (ZeroOne.Checked || OneMinus.Checked || Interval.Checked) Scale.Enabled = true;
        }

        private Bitmap RGBtoGray(Bitmap img)
        {
            var result = new Bitmap(img);
            for (int x = 0; x < result.Width; ++x)
                for (int y = 0; y < result.Height; ++y)
                {
                    Color c = result.GetPixel(x, y);
                    result.SetPixel(x, y, ColorToGray(c));
                }
            return result;
        }

        private Color ColorToGray(Color c)
        {
            Byte r = c.R, g = c.G, b = c.B;
            r = g = b = Convert.ToByte(Convert.ToInt32(0.299 * r + 0.587 * g + 0.114 * b));
            return Color.FromArgb(c.A, (int) r, (int) g, (int) b);
        }

        private void ZeroOne_CheckedChanged(object sender, EventArgs e)
        {
            _from = 0;
            _to = 1;
            From.Enabled = false;
            To.Enabled = false;
            _interval = false;
        }

        private void OneMinus_CheckedChanged(object sender, EventArgs e)
        {
            _from = -1;
            _to = 1;
            From.Enabled = false;
            To.Enabled = false;
            _interval = false;
        }

        private void Interval_CheckedChanged(object sender, EventArgs e)
        {
            From.Enabled = true;
            To.Enabled = true;
            _interval = true;
        }

        private void WithoutInterval()
        {
            var grayImg = RGBtoGray(image);
            _background = ColorToGray(_background);
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"..\..\result.txt");
            var img = new Bitmap(grayImg);
            for (int y = 0; y < img.Height; ++y)
            {
                for (int x = 0; x < img.Width; ++x)
                {
                    Color color = img.GetPixel(x, y);
                    if (Math.Abs(color.R - _background.R) < 10 &
                         Math.Abs(color.G - _background.G) < 10 &
                         Math.Abs(color.B - _background.B) < 10)
                    {
                        img.SetPixel(x, y, Color.White);
                        textFile.Write(_from.ToString());
                    }
                    else
                    {
                        img.SetPixel(x, y, Color.Black);
                        textFile.Write(_to.ToString());
                    }

                }
                textFile.WriteLine();
            }
            textFile.Close();
            Result.Image = img;
        }

        private void WithInterval()
        {
            var grayImg = RGBtoGray(image);
            _background = ColorToGray(_background);
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"..\..\result.txt");
            var img = new Bitmap(grayImg);
            var from=Double.Parse(From.Text);
            var to = Double.Parse(To.Text);
            double step = Math.Abs(to - from)/255;
            for (int y = 0; y < img.Height; ++y)
            {
                for (int x = 0; x < img.Width; ++x)
                {
                    Color color = img.GetPixel(x, y);
                    double res = Math.Round(from+color.R*step, 2);
                    textFile.Write(res.ToString()+" ");

                }
                textFile.WriteLine();
            }
            textFile.Close();
            Result.Image = img;
        }


        private void Scale_Click(object sender, EventArgs e)
        {
            if (_interval)
                WithInterval();
            else
                WithoutInterval();
        }
    }
}
