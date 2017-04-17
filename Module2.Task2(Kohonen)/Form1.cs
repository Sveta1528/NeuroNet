using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Module2.Task2_Kohonen_
{
    public partial class Form1 : MetroForm
    {
        Kohonen net;
        List<List<double>> data = new List<List<double>>();
        private List<Color> colors = new List<Color>()
        {
            Color.Blue, Color.Green, Color.DeepPink, Color.Orange, Color.Aqua,  Color.Red, Color.Chartreuse,
            Color.DarkViolet, Color.LightSeaGreen, Color.LightCoral, Color.Yellow,Color.AliceBlue,Color.Bisque,
            Color.Maroon, Color.Tomato
        };

        public Form1()
        {
            InitializeComponent();
            SetData();
        }

        private void Draw()
        {
            List<List<Color>> pic = net.NewRender();
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(Color.White);
            float curPosX = 0, curPosY = 0;
            for (int i = 0; i < pic.Count; ++i)
            {
                for (int j = 0; j < pic[i].Count; ++j)
                {

                    gr.FillRectangle(new Pen(pic[i][j], 3).Brush, j, i, 1, 1);
                }
            }

        }

        private void SetData()
        {
            int count = (int)CountColors.Value;
            data.Clear();
            for (int i = 0; i < count; ++i)
                data.Add(new List<double>() {colors[i].R, colors[i].G, colors[i].B});
        }

        private void CountColors_ValueChanged(object sender, EventArgs e) => SetData();

        private void Learn_Click(object sender, EventArgs e)
        {
            net = new Kohonen((int)SizeX.Value, (int)SizeY.Value, 3);
            ProgressBar.Value = 0;
            ProgressBar.Minimum = 0;
            ProgressBar.MarqueeAnimationSpeed = 1;
            ProgressBar.Maximum = Convert.ToInt32(Iteration.Text);
            net.Learn(ref data, Convert.ToInt32(Iteration.Text), ref ProgressBar);
            ProgressBar.Value = ProgressBar.Maximum;
            Draw();
        }
    }
}
