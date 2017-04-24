using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Task3
{
    public partial class Form1 : MetroForm
    {
        private NeuralNetwork net;
        // Максимальное количество повторений обучения
        const long num_iter = 5000000;
        // Минимальная допустимая средняя квадратичная ошибка
        const double Thresh = 0.000001;

        public Form1()
        {
            InitializeComponent();
            layers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        void DeleteLayersTextBox()
        {
            for (int i = 0; i < 10; i++)
            {
                var control = this.Controls["layer" + (i + 1).ToString()];
                if (Controls.Contains(control))
                {
                    Controls.Remove(control);
                    Controls.Remove(this.Controls["layerlabel" + (i + 1).ToString()]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteLayersTextBox();

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
            DeleteLayersTextBox();
        }



        private int[] GetCountsNeuron()
        {
            int count_input = data[0].Length;
            int count_output = answer[0].Length;
            if (Default.Checked)
                return new[] { count_input, count_input, count_output };
            else
            {
                int count_layers = Int32.Parse(layers.Text);
                int n = 2 + count_layers;
                var result = new int[n];
                result[0] = count_input;
                result[n - 1] = count_output;
                for (int i = 1; i < n - 1; i++)
                {
                    var control = this.Controls["layer" + i.ToString()];
                    result[i] = Int32.Parse(control.Text);
                }
                return result;

            }

        }

        private void Learn_Click(object sender, EventArgs e)
        {
            int[] neuronsArr = GetCountsNeuron();
            double speed = double.Parse(Speed.Text);
            net = new NeuralNetwork(neuronsArr.Length, neuronsArr, speed, 0.1);
            Logs.Text = "";
            backgroundWorker.ReportProgress(10);
            // Начинаем обучение сети
            long i;
            var sb = new StringBuilder();
            for (i = 0; i < num_iter; i++)
            {

                // Запускаем обучение
                net.BackPropogate(data[i % 8], answer[i % 8]);

                // Проверяем среднюю кважротичную ошибку
                var error = net.mse(answer[i % 8]);
                if (error < Thresh)
                {

                    Logs.Text += "Сеть обучена. Выполнено " + i + " повтореий" + Environment.NewLine;
                    Logs.Text += "Средняя квадратичная ошибка:  " + error + Environment.NewLine;
                    break;
                }


                // Выводим статус каждые 10% прогресса
                if (i % (num_iter / 10) == 0)
                {
                    error = net.mse(answer[i % 8]);
                    Logs.Text += "Средняя квадратичная ошибка:  " + error + Environment.NewLine;
                    Logs.Text += "... Идет обучение..." + Environment.NewLine;
                }

            }


            // Если цикл дошел до предела, вместо того, чтобы средняя квадротичная ошибка стала приемлимой
            if (i == num_iter)
            {
                Logs.Text += "Истекло количество повторений" + Environment.NewLine;
                Logs.Text += "Средняя квадратичная ошибка:  " + net.mse(answer[i % 8]) + Environment.NewLine;
            }
        }

        // Данные для обучения функции XOR
        //double [] data  = {0,0,0,0};
        double [][] data  = {
        new double[] {0, 0, 0},
        new double[] {0, 0, 1},
        new double[] {0, 1, 0},
        new double[] {0, 1, 1},
        new double[] {1, 0, 0},
        new double[] {1, 0, 1},
        new double[] {1, 1, 0},
        new double[] { 1, 1, 1}
	};

        private double[][] answer =
        {
            new double[] {0},
            new double[] {1},
            new double[] {1},
            new double[] {0},
            new double[] {1},
            new double[] {0},
            new double[] {0},
            new double[] {1},
        };

        private void Recognize_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            net.FeedForwards(new []{double.Parse(X.Text), double.Parse(Y.Text) , double.Parse(Z.Text) });
            foreach (var variable in net.Out())
                Result.Text += variable.ToString() + "  ";
                

        }
    }
}
