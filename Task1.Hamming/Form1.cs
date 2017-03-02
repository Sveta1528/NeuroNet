using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private List<int[]> patterns = new List<int[]>();

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

        private void CreatePatternsList()
        {
            string[] files = Directory.GetFiles(@PatternPath.Text);
            foreach (string file in files)
            {
                Bitmap cur = new Bitmap(file);
                int[] res = new int[cur.Width*cur.Height];
                BM.BitmapToArray(ref cur, cur.GetPixel(0, 0), ref res);
                patterns.Add(res);
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int w = in_img.Width, h = in_img.Height;
            int[] input = new int[w* h];
            BM.BitmapToArray(ref in_img, in_img.GetPixel(0, 0), ref input);
            //int [] res =hopfield_net.Recognize(ref input);
            Bitmap result = new Bitmap(in_img);
            //BM.ArrayToBitmap(ref res,w,h,ref result);
            OutputImage.Image = result;
        }

        private void Learn_Click(object sender, EventArgs e)
        {
            CreatePatternsList();
            //hopfield_net = new HopfieldNet(ref patterns);
                
        }
    }
}
