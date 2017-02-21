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

namespace Task0
{
    public partial class Form1 : MetroForm
    {
        private Bitmap image;
        private Color current;

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName == "")
                return;
            image = new Bitmap(openFileDialog1.FileName);
            InputPicture.Image = image;
        }

        private void InputPicture_MouseClick(object sender, MouseEventArgs e)
        {
            Color color = image.GetPixel(e.X, e.Y);
            current = color;
            CurrentColor.BackColor = color;
        }
    }
}
