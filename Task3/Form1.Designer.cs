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
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.layers = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Learn = new System.Windows.Forms.Button();
            this.Recognize = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(23, 22);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(108, 15);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.Text = "По умолчанию";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
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
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.layers.Location = new System.Drawing.Point(148, 67);
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(44, 21);
            this.layers.TabIndex = 3;
            this.layers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(403, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(214, 46);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(147, 20);
            this.Path.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Путь к обучающей выборке:";
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(214, 72);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(147, 31);
            this.Learn.TabIndex = 19;
            this.Learn.Text = "Обучить";
            this.Learn.UseVisualStyleBackColor = true;
            // 
            // Recognize
            // 
            this.Recognize.Location = new System.Drawing.Point(214, 194);
            this.Recognize.Name = "Recognize";
            this.Recognize.Size = new System.Drawing.Size(147, 31);
            this.Recognize.TabIndex = 20;
            this.Recognize.Text = "Распознать";
            this.Recognize.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(214, 152);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(147, 31);
            this.Load.TabIndex = 21;
            this.Load.Text = "Загрузить изображение";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(403, 152);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 73);
            this.Result.TabIndex = 22;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(214, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(147, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 256);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Recognize);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private System.Windows.Forms.ComboBox layers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Button Recognize;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

