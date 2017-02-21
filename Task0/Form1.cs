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
        private Color current = Color.Empty;

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
            current = color;
            CurrentColor.BackColor = color;
            if (ZeroOne.Checked || OneMinus.Checked || Interval.Checked) Scale.Enabled = true;
        }

        private void RGBtoGray()
        {
            for (int x = 0; x < image.Width; ++x)
                for (int y = 0; y < image.Height; ++y)
                {
                    Color c = image.GetPixel(x, y);
                    image.SetPixel(x, y, ColorToGray(c));
                }
        }

        private Color ColorToGray(Color c)
        {
            Byte r = c.R, g = c.G, b = c.B;
            r = g = b = Convert.ToByte(Convert.ToInt32(0.299 * r + 0.587 * g + 0.114 * b));
            return Color.FromArgb(c.A, (int) r, (int) g, (int) b);
        }

        private void ZeroOne_CheckedChanged(object sender, EventArgs e)
        {
            if (current != Color.Empty) Scale.Enabled = true; 

        }

        private void OneMinus_CheckedChanged(object sender, EventArgs e)
        {
            if (current != Color.Empty) Scale.Enabled = true;
        }

        private void Interval_CheckedChanged(object sender, EventArgs e)
        {
            if (current != Color.Empty) Scale.Enabled = true;
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            RGBtoGray();
            current = ColorToGray(current);
        }
    }
}
