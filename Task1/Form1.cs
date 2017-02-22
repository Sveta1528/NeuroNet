using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Task1
{
    public partial class Form1 : MetroForm
    {
        private Bitmap in_img;
        private Color back_color;
        private BitmapManipulation BM = new BitmapManipulation();
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
                in_img = new Bitmap(openFileDialog1.FileName);
                InputImage.Image = in_img;
                back_color = in_img.GetPixel(0, 0);
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
        }
    }
}
