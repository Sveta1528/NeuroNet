namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputImage = new System.Windows.Forms.PictureBox();
            this.OutputImage = new System.Windows.Forms.PictureBox();
            this.Load = new MetroFramework.Controls.MetroButton();
            this.Hopfield = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.Learn = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PatternPath = new MetroFramework.Controls.MetroTextBox();
            this.Result = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Noise = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputImage
            // 
            this.InputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputImage.Location = new System.Drawing.Point(18, 69);
            this.InputImage.Name = "InputImage";
            this.InputImage.Size = new System.Drawing.Size(100, 100);
            this.InputImage.TabIndex = 0;
            this.InputImage.TabStop = false;
            // 
            // OutputImage
            // 
            this.OutputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputImage.Location = new System.Drawing.Point(293, 69);
            this.OutputImage.Name = "OutputImage";
            this.OutputImage.Size = new System.Drawing.Size(100, 100);
            this.OutputImage.TabIndex = 1;
            this.OutputImage.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(18, 26);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(100, 33);
            this.Load.TabIndex = 2;
            this.Load.Text = "Загрузить";
            this.Load.UseSelectable = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Hopfield
            // 
            this.Hopfield.AutoSize = true;
            this.Hopfield.Location = new System.Drawing.Point(136, 66);
            this.Hopfield.Name = "Hopfield";
            this.Hopfield.Size = new System.Drawing.Size(107, 15);
            this.Hopfield.TabIndex = 3;
            this.Hopfield.Text = "Сеть Хопфилда";
            this.Hopfield.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(136, 87);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(107, 15);
            this.metroRadioButton1.TabIndex = 4;
            this.metroRadioButton1.Text = "Сеть Хемминга";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(136, 108);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(138, 33);
            this.Learn.TabIndex = 5;
            this.Learn.Text = "Обучить";
            this.Learn.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.Noise);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.InputImage);
            this.metroPanel2.Controls.Add(this.PatternPath);
            this.metroPanel2.Controls.Add(this.OutputImage);
            this.metroPanel2.Controls.Add(this.Result);
            this.metroPanel2.Controls.Add(this.Learn);
            this.metroPanel2.Controls.Add(this.Hopfield);
            this.metroPanel2.Controls.Add(this.metroRadioButton1);
            this.metroPanel2.Controls.Add(this.Load);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(27, 31);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(407, 195);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(136, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Путь до образцов:";
            // 
            // PatternPath
            // 
            // 
            // 
            // 
            this.PatternPath.CustomButton.Image = null;
            this.PatternPath.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.PatternPath.CustomButton.Name = "";
            this.PatternPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PatternPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PatternPath.CustomButton.TabIndex = 1;
            this.PatternPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PatternPath.CustomButton.UseSelectable = true;
            this.PatternPath.CustomButton.Visible = false;
            this.PatternPath.Lines = new string[0];
            this.PatternPath.Location = new System.Drawing.Point(136, 37);
            this.PatternPath.MaxLength = 32767;
            this.PatternPath.Name = "PatternPath";
            this.PatternPath.PasswordChar = '\0';
            this.PatternPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PatternPath.SelectedText = "";
            this.PatternPath.SelectionLength = 0;
            this.PatternPath.SelectionStart = 0;
            this.PatternPath.Size = new System.Drawing.Size(138, 23);
            this.PatternPath.TabIndex = 8;
            this.PatternPath.UseSelectable = true;
            this.PatternPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PatternPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(293, 26);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 33);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результат";
            this.Result.UseSelectable = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Noise
            // 
            this.Noise.Location = new System.Drawing.Point(136, 147);
            this.Noise.Name = "Noise";
            this.Noise.Size = new System.Drawing.Size(138, 33);
            this.Noise.TabIndex = 10;
            this.Noise.Text = "Зашумить";
            this.Noise.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 239);
            this.Controls.Add(this.metroPanel2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InputImage;
        private System.Windows.Forms.PictureBox OutputImage;
        private MetroFramework.Controls.MetroButton Load;
        private MetroFramework.Controls.MetroRadioButton Hopfield;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroButton Learn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton Result;
        private MetroFramework.Controls.MetroTextBox PatternPath;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton Noise;
    }
}

