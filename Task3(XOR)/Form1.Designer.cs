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
            this.Selection = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.layers = new System.Windows.Forms.ComboBox();
            this.Learn = new System.Windows.Forms.Button();
            this.Recognize = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Speed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Logs = new System.Windows.Forms.TextBox();
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
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Location = new System.Drawing.Point(23, 43);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(129, 15);
            this.Selection.TabIndex = 2;
            this.Selection.Text = "Выбор параметров";
            this.Selection.UseSelectable = true;
            this.Selection.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
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
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(214, 27);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(153, 31);
            this.Learn.TabIndex = 19;
            this.Learn.Text = "Обучить";
            this.Learn.UseVisualStyleBackColor = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // Recognize
            // 
            this.Recognize.Location = new System.Drawing.Point(214, 99);
            this.Recognize.Name = "Recognize";
            this.Recognize.Size = new System.Drawing.Size(153, 31);
            this.Recognize.TabIndex = 20;
            this.Recognize.Text = "Распознать";
            this.Recognize.UseVisualStyleBackColor = true;
            this.Recognize.Click += new System.EventHandler(this.Recognize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(133, 158);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(44, 20);
            this.Speed.TabIndex = 24;
            this.Speed.Text = "0,5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Скорость обучения:";
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(323, 73);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(44, 20);
            this.Z.TabIndex = 26;
            this.Z.Text = "0";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(273, 73);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(44, 20);
            this.Y.TabIndex = 27;
            this.Y.Text = "0";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(214, 73);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(44, 20);
            this.X.TabIndex = 28;
            this.X.Text = "0";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(214, 138);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(153, 20);
            this.Result.TabIndex = 29;
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(23, 217);
            this.Logs.Multiline = true;
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(344, 141);
            this.Logs.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 394);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Recognize);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.Default);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton Default;
        private MetroFramework.Controls.MetroRadioButton Selection;
        private System.Windows.Forms.ComboBox layers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Learn;
        private System.Windows.Forms.Button Recognize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox Speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Z;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox Logs;
    }
}

