namespace Task3
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
            this.Default = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.layers = new System.Windows.Forms.ComboBox();
            this.InputImage = new System.Windows.Forms.PictureBox();
            this.PatternPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Learn = new System.Windows.Forms.Button();
            this.Recognize = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Logs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Accuracy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Default
            // 
            this.Default.AutoSize = true;
            this.Default.Checked = true;
            this.Default.Location = new System.Drawing.Point(23, 22);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(108, 15);
            this.Default.TabIndex = 0;
            this.Default.TabStop = true;
            this.Default.Text = "По умолчанию";
            this.Default.UseSelectable = true;
            this.Default.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(23, 43);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(129, 15);
            this.metroRadioButton2.TabIndex = 2;
            this.metroRadioButton2.Text = "Выбор параметров";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Количество слоев";
            // 
            // layers
            // 
            this.layers.Enabled = false;
            this.layers.FormattingEnabled = true;
            this.layers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.layers.Location = new System.Drawing.Point(148, 67);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(44, 21);
            this.layers.TabIndex = 3;
            this.layers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InputImage
            // 
            this.InputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputImage.Location = new System.Drawing.Point(234, 73);
            this.InputImage.Name = "InputImage";
            this.InputImage.Size = new System.Drawing.Size(100, 100);
            this.InputImage.TabIndex = 16;
            this.InputImage.TabStop = false;
            // 
            // PatternPath
            // 
            this.PatternPath.Location = new System.Drawing.Point(23, 266);
            this.PatternPath.Name = "PatternPath";
            this.PatternPath.Size = new System.Drawing.Size(154, 20);
            this.PatternPath.TabIndex = 17;
            this.PatternPath.Text = "..\\..\\Patterns\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Путь к обучающей выборке:";
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(23, 299);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(154, 26);
            this.Learn.TabIndex = 19;
            this.Learn.Text = "Обучить";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // Recognize
            // 
            this.Recognize.Location = new System.Drawing.Point(234, 188);
            this.Recognize.Name = "Recognize";
            this.Recognize.Size = new System.Drawing.Size(100, 27);
            this.Recognize.TabIndex = 20;
            this.Recognize.Text = "Распознать";
            this.Recognize.UseVisualStyleBackColor = true;
            this.Recognize.Click += new System.EventHandler(this.Recognize_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(234, 27);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(100, 27);
            this.Load.TabIndex = 21;
            this.Load.Text = "Загрузить";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(234, 258);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 20);
            this.Result.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(362, 27);
            this.Logs.Multiline = true;
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(246, 264);
            this.Logs.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Скорость обучения:";
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(133, 165);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(44, 20);
            this.Speed.TabIndex = 31;
            this.Speed.Text = "0,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Результат:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Точность :";
            // 
            // Accuracy
            // 
            this.Accuracy.Location = new System.Drawing.Point(133, 195);
            this.Accuracy.Name = "Accuracy";
            this.Accuracy.Size = new System.Drawing.Size(44, 20);
            this.Accuracy.TabIndex = 35;
            this.Accuracy.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Accuracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Recognize);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatternPath);
            this.Controls.Add(this.InputImage);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.Default);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton Default;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private System.Windows.Forms.ComboBox layers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox InputImage;
        private System.Windows.Forms.TextBox PatternPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Button Recognize;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Logs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Accuracy;
    }
}

