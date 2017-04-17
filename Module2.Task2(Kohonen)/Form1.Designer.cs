namespace Module2.Task2_Kohonen_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.Learn = new MetroFramework.Controls.MetroButton();
            this.SizeX = new System.Windows.Forms.NumericUpDown();
            this.SizeY = new System.Windows.Forms.NumericUpDown();
            this.CountColors = new System.Windows.Forms.NumericUpDown();
            this.Iteration = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(327, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Количество итераций:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(327, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Размер:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(327, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Количество цветов:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(332, 162);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(193, 23);
            this.ProgressBar.TabIndex = 11;
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(332, 203);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(193, 30);
            this.Learn.TabIndex = 13;
            this.Learn.Text = "Обучить";
            this.Learn.UseSelectable = true;
            this.Learn.Click += new System.EventHandler(this.Learn_Click);
            // 
            // SizeX
            // 
            this.SizeX.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SizeX.Location = new System.Drawing.Point(397, 60);
            this.SizeX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SizeX.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SizeX.Name = "SizeX";
            this.SizeX.Size = new System.Drawing.Size(45, 20);
            this.SizeX.TabIndex = 14;
            this.SizeX.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // SizeY
            // 
            this.SizeY.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SizeY.Location = new System.Drawing.Point(457, 60);
            this.SizeY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.SizeY.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SizeY.Name = "SizeY";
            this.SizeY.Size = new System.Drawing.Size(45, 20);
            this.SizeY.TabIndex = 15;
            this.SizeY.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // CountColors
            // 
            this.CountColors.Location = new System.Drawing.Point(480, 94);
            this.CountColors.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.CountColors.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CountColors.Name = "CountColors";
            this.CountColors.Size = new System.Drawing.Size(45, 20);
            this.CountColors.TabIndex = 16;
            this.CountColors.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.CountColors.ValueChanged += new System.EventHandler(this.CountColors_ValueChanged);
            // 
            // Iteration
            // 
            this.Iteration.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Iteration.Location = new System.Drawing.Point(480, 127);
            this.Iteration.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.Iteration.Name = "Iteration";
            this.Iteration.Size = new System.Drawing.Size(45, 20);
            this.Iteration.TabIndex = 17;
            this.Iteration.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 330);
            this.Controls.Add(this.Iteration);
            this.Controls.Add(this.CountColors);
            this.Controls.Add(this.SizeY);
            this.Controls.Add(this.SizeX);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iteration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar ProgressBar;
        private MetroFramework.Controls.MetroButton Learn;
        private System.Windows.Forms.NumericUpDown SizeX;
        private System.Windows.Forms.NumericUpDown SizeY;
        private System.Windows.Forms.NumericUpDown CountColors;
        private System.Windows.Forms.NumericUpDown Iteration;
    }
}

