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

namespace Task3
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            layers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var control = this.Controls["layer"+(i + 1).ToString()];
                if (Controls.Contains(control))
                {
                    Controls.Remove(control);
                    Controls.Remove(this.Controls["layerlabel" + (i + 1).ToString()]);
                }
            }
            var count = Int32.Parse(layers.SelectedItem.ToString());
            int lx = 30, ly = 103, tbx = 55, tby = 98;
            int k = 0;
            for (int i = 0; i < count; i += 2)
            {
                int newlx = lx,
                    newly = ly + k * 25,
                    newtbx = tbx,
                    newtby = tby + k * 25;
                k++;
                    this.Controls.Add(new Label()
                    {
                        Name = "layerlabel" + k.ToString(),
                        Text = k.ToString() + ":",
                        Location = new Point(newlx, newly),
                        Size = new Size(23, 13)
                    });
                    this.Controls.Add(new TextBox()
                    {
                        Name = "layer" + k.ToString(),
                        Location = new Point(newtbx, newtby),
                        Size = new Size(46, 20)
                    });
            }
            
            int j = 0;
            for (int i = 1; i < count; i += 2)
            {
                int newlx = lx+79,
                    newly = ly + j * 25,
                    newtbx = tbx+79,
                newtby = tby + j * 25;
                j++; k++;
                    this.Controls.Add(new Label()
                    {
                        Name = "layerlabel" + k.ToString(),
                        Text = k.ToString() + ":",
                        Location = new Point(newlx, newly),
                        Size = new Size(23, 13)
                    });
                    this.Controls.Add(new TextBox()
                    {
                        Name = "layer" + k.ToString(),
                        Location = new Point(newtbx, newtby),
                        Size = new Size(46, 20)
                    });
                
            }
            
            
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            layers.Enabled = true;
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            layers.Enabled = false;
        }
    }
}
