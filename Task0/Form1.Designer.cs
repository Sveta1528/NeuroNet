namespace Task0
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
            this.Load = new MetroFramework.Controls.MetroButton();
            this.InputPicture = new System.Windows.Forms.PictureBox();
            this.ZeroOne = new System.Windows.Forms.RadioButton();
            this.OneMinus = new System.Windows.Forms.RadioButton();
            this.Interval = new System.Windows.Forms.RadioButton();
            this.From = new MetroFramework.Controls.MetroTextBox();
            this.To = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentColor = new System.Windows.Forms.PictureBox();
            this.Scale = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColor)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(18, 137);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(100, 39);
            this.Load.TabIndex = 0;
            this.Load.Text = "Загрузить";
            this.Load.UseSelectable = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // InputPicture
            // 
            this.InputPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPicture.Location = new System.Drawing.Point(18, 11);
            this.InputPicture.Name = "InputPicture";
            this.InputPicture.Size = new System.Drawing.Size(100, 100);
            this.InputPicture.TabIndex = 1;
            this.InputPicture.TabStop = false;
            this.InputPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InputPicture_MouseClick);
            // 
            // ZeroOne
            // 
            this.ZeroOne.AutoSize = true;
            this.ZeroOne.Location = new System.Drawing.Point(18, 38);
            this.ZeroOne.Name = "ZeroOne";
            this.ZeroOne.Size = new System.Drawing.Size(103, 17);
            this.ZeroOne.TabIndex = 2;
            this.ZeroOne.Text = "Сигнал из 0 и 1";
            this.ZeroOne.UseVisualStyleBackColor = true;
            this.ZeroOne.CheckedChanged += new System.EventHandler(this.ZeroOne_CheckedChanged);
            // 
            // OneMinus
            // 
            this.OneMinus.AutoSize = true;
            this.OneMinus.Location = new System.Drawing.Point(18, 55);
            this.OneMinus.Name = "OneMinus";
            this.OneMinus.Size = new System.Drawing.Size(106, 17);
            this.OneMinus.TabIndex = 3;
            this.OneMinus.Text = "Сигнал из 1 и -1";
            this.OneMinus.UseVisualStyleBackColor = true;
            this.OneMinus.CheckedChanged += new System.EventHandler(this.OneMinus_CheckedChanged);
            // 
            // Interval
            // 
            this.Interval.AutoSize = true;
            this.Interval.Location = new System.Drawing.Point(18, 73);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(85, 17);
            this.Interval.TabIndex = 4;
            this.Interval.Text = "В интервал:";
            this.Interval.UseVisualStyleBackColor = true;
            this.Interval.CheckedChanged += new System.EventHandler(this.Interval_CheckedChanged);
            // 
            // From
            // 
            // 
            // 
            // 
            this.From.CustomButton.Image = null;
            this.From.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.From.CustomButton.Name = "";
            this.From.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.From.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.From.CustomButton.TabIndex = 1;
            this.From.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.From.CustomButton.UseSelectable = true;
            this.From.CustomButton.Visible = false;
            this.From.Enabled = false;
            this.From.Lines = new string[0];
            this.From.Location = new System.Drawing.Point(46, 92);
            this.From.MaxLength = 32767;
            this.From.Name = "From";
            this.From.PasswordChar = '\0';
            this.From.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.From.SelectedText = "";
            this.From.SelectionLength = 0;
            this.From.SelectionStart = 0;
            this.From.Size = new System.Drawing.Size(31, 23);
            this.From.TabIndex = 5;
            this.From.UseSelectable = true;
            this.From.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.From.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // To
            // 
            // 
            // 
            // 
            this.To.CustomButton.Image = null;
            this.To.CustomButton.Location = new System.Drawing.Point(9, 1);
            this.To.CustomButton.Name = "";
            this.To.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.To.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.To.CustomButton.TabIndex = 1;
            this.To.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.To.CustomButton.UseSelectable = true;
            this.To.CustomButton.Visible = false;
            this.To.Enabled = false;
            this.To.Lines = new string[0];
            this.To.Location = new System.Drawing.Point(111, 90);
            this.To.MaxLength = 32767;
            this.To.Name = "To";
            this.To.PasswordChar = '\0';
            this.To.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.To.SelectedText = "";
            this.To.SelectionLength = 0;
            this.To.SelectionStart = 0;
            this.To.Size = new System.Drawing.Size(31, 23);
            this.To.TabIndex = 6;
            this.To.UseSelectable = true;
            this.To.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.To.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "До:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.CurrentColor);
            this.metroPanel1.Controls.Add(this.Scale);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.To);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.From);
            this.metroPanel1.Controls.Add(this.ZeroOne);
            this.metroPanel1.Controls.Add(this.OneMinus);
            this.metroPanel1.Controls.Add(this.Interval);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(165, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(159, 183);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Цвет фона:";
            // 
            // CurrentColor
            // 
            this.CurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentColor.Location = new System.Drawing.Point(91, 9);
            this.CurrentColor.Name = "CurrentColor";
            this.CurrentColor.Size = new System.Drawing.Size(25, 23);
            this.CurrentColor.TabIndex = 10;
            this.CurrentColor.TabStop = false;
            // 
            // Scale
            // 
            this.Scale.Enabled = false;
            this.Scale.Location = new System.Drawing.Point(16, 125);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(124, 39);
            this.Scale.TabIndex = 9;
            this.Scale.Text = "Масштабировать";
            this.Scale.UseSelectable = true;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.Load);
            this.metroPanel2.Controls.Add(this.InputPicture);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 19);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(137, 194);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 227);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            ((System.ComponentModel.ISupportInitialize)(this.InputPicture)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentColor)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Load;
        private System.Windows.Forms.PictureBox InputPicture;
        private System.Windows.Forms.RadioButton ZeroOne;
        private System.Windows.Forms.RadioButton OneMinus;
        private System.Windows.Forms.RadioButton Interval;
        private MetroFramework.Controls.MetroTextBox From;
        private MetroFramework.Controls.MetroTextBox To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton Scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CurrentColor;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

