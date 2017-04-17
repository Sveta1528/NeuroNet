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
            this.SizeX = new MetroFramework.Controls.MetroTextBox();
            this.SizeY = new MetroFramework.Controls.MetroTextBox();
            this.Colors = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Iteration = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.Create = new MetroFramework.Controls.MetroButton();
            this.Learn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SizeX
            // 
            // 
            // 
            // 
            this.SizeX.CustomButton.Image = null;
            this.SizeX.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.SizeX.CustomButton.Name = "";
            this.SizeX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SizeX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SizeX.CustomButton.TabIndex = 1;
            this.SizeX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SizeX.CustomButton.UseSelectable = true;
            this.SizeX.CustomButton.Visible = false;
            this.SizeX.Lines = new string[] {
        "200"};
            this.SizeX.Location = new System.Drawing.Point(326, 87);
            this.SizeX.MaximumSize = new System.Drawing.Size(300, 300);
            this.SizeX.MaxLength = 32767;
            this.SizeX.Name = "SizeX";
            this.SizeX.PasswordChar = '\0';
            this.SizeX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SizeX.SelectedText = "";
            this.SizeX.SelectionLength = 0;
            this.SizeX.SelectionStart = 0;
            this.SizeX.Size = new System.Drawing.Size(40, 23);
            this.SizeX.TabIndex = 2;
            this.SizeX.Text = "200";
            this.SizeX.UseSelectable = true;
            this.SizeX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SizeX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SizeY
            // 
            // 
            // 
            // 
            this.SizeY.CustomButton.Image = null;
            this.SizeY.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.SizeY.CustomButton.Name = "";
            this.SizeY.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SizeY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SizeY.CustomButton.TabIndex = 1;
            this.SizeY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SizeY.CustomButton.UseSelectable = true;
            this.SizeY.CustomButton.Visible = false;
            this.SizeY.Lines = new string[] {
        "200"};
            this.SizeY.Location = new System.Drawing.Point(371, 87);
            this.SizeY.MaxLength = 32767;
            this.SizeY.Name = "SizeY";
            this.SizeY.PasswordChar = '\0';
            this.SizeY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SizeY.SelectedText = "";
            this.SizeY.SelectionLength = 0;
            this.SizeY.SelectionStart = 0;
            this.SizeY.Size = new System.Drawing.Size(40, 23);
            this.SizeY.TabIndex = 3;
            this.SizeY.Text = "200";
            this.SizeY.UseSelectable = true;
            this.SizeY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SizeY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Colors
            // 
            // 
            // 
            // 
            this.Colors.CustomButton.Image = null;
            this.Colors.CustomButton.Location = new System.Drawing.Point(2, 1);
            this.Colors.CustomButton.Name = "";
            this.Colors.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Colors.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Colors.CustomButton.TabIndex = 1;
            this.Colors.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Colors.CustomButton.UseSelectable = true;
            this.Colors.CustomButton.Visible = false;
            this.Colors.Lines = new string[] {
        "8"};
            this.Colors.Location = new System.Drawing.Point(452, 126);
            this.Colors.MaxLength = 32767;
            this.Colors.Name = "Colors";
            this.Colors.PasswordChar = '\0';
            this.Colors.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Colors.SelectedText = "";
            this.Colors.SelectionLength = 0;
            this.Colors.SelectionStart = 0;
            this.Colors.Size = new System.Drawing.Size(24, 23);
            this.Colors.TabIndex = 6;
            this.Colors.Text = "8";
            this.Colors.UseSelectable = true;
            this.Colors.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Colors.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(318, 161);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Количество итераций:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(318, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Размер:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(318, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Количество цветов:";
            // 
            // Iteration
            // 
            // 
            // 
            // 
            this.Iteration.CustomButton.Image = null;
            this.Iteration.CustomButton.Location = new System.Drawing.Point(18, 1);
            this.Iteration.CustomButton.Name = "";
            this.Iteration.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Iteration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Iteration.CustomButton.TabIndex = 1;
            this.Iteration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Iteration.CustomButton.UseSelectable = true;
            this.Iteration.CustomButton.Visible = false;
            this.Iteration.Lines = new string[] {
        "350"};
            this.Iteration.Location = new System.Drawing.Point(326, 187);
            this.Iteration.MaxLength = 32767;
            this.Iteration.Name = "Iteration";
            this.Iteration.PasswordChar = '\0';
            this.Iteration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Iteration.SelectedText = "";
            this.Iteration.SelectionLength = 0;
            this.Iteration.SelectionStart = 0;
            this.Iteration.Size = new System.Drawing.Size(40, 23);
            this.Iteration.TabIndex = 10;
            this.Iteration.Text = "350";
            this.Iteration.UseSelectable = true;
            this.Iteration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Iteration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(326, 225);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(176, 23);
            this.metroProgressBar1.TabIndex = 11;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(417, 87);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(85, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Создать";
            this.Create.UseSelectable = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(388, 187);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(114, 23);
            this.Learn.TabIndex = 13;
            this.Learn.Text = "Обучить";
            this.Learn.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.Controls.Add(this.Learn);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.Iteration);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.SizeY);
            this.Controls.Add(this.SizeX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox SizeX;
        private MetroFramework.Controls.MetroTextBox SizeY;
        private MetroFramework.Controls.MetroTextBox Colors;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Iteration;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton Create;
        private MetroFramework.Controls.MetroButton Learn;
    }
}

