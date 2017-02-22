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
            this.OutpuyImage = new System.Windows.Forms.PictureBox();
            this.Load = new MetroFramework.Controls.MetroButton();
            this.Hopfield = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.Learn = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.Result = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutpuyImage)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputImage
            // 
            this.InputImage.Location = new System.Drawing.Point(13, 10);
            this.InputImage.Name = "InputImage";
            this.InputImage.Size = new System.Drawing.Size(100, 100);
            this.InputImage.TabIndex = 0;
            this.InputImage.TabStop = false;
            // 
            // OutpuyImage
            // 
            this.OutpuyImage.Location = new System.Drawing.Point(134, 10);
            this.OutpuyImage.Name = "OutpuyImage";
            this.OutpuyImage.Size = new System.Drawing.Size(100, 100);
            this.OutpuyImage.TabIndex = 1;
            this.OutpuyImage.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(18, 16);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(84, 33);
            this.Load.TabIndex = 2;
            this.Load.Text = "Загрузить ";
            this.Load.UseSelectable = true;
            // 
            // Hopfield
            // 
            this.Hopfield.AutoSize = true;
            this.Hopfield.Location = new System.Drawing.Point(9, 11);
            this.Hopfield.Name = "Hopfield";
            this.Hopfield.Size = new System.Drawing.Size(107, 15);
            this.Hopfield.TabIndex = 3;
            this.Hopfield.Text = "Сеть Хопфилда";
            this.Hopfield.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(9, 32);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(107, 15);
            this.metroRadioButton1.TabIndex = 4;
            this.metroRadioButton1.Text = "Сеть Хемминга";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // Learn
            // 
            this.Learn.Location = new System.Drawing.Point(16, 58);
            this.Learn.Name = "Learn";
            this.Learn.Size = new System.Drawing.Size(92, 33);
            this.Learn.TabIndex = 5;
            this.Learn.Text = "Обучить";
            this.Learn.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.InputImage);
            this.metroPanel1.Controls.Add(this.OutpuyImage);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(10, 146);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(248, 124);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.Result);
            this.metroPanel2.Controls.Add(this.Load);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(10, 26);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(118, 114);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(18, 59);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(84, 33);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результат";
            this.Result.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.Learn);
            this.metroPanel3.Controls.Add(this.metroRadioButton1);
            this.metroPanel3.Controls.Add(this.Hopfield);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(134, 26);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(126, 114);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 282);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutpuyImage)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox InputImage;
        private System.Windows.Forms.PictureBox OutpuyImage;
        private MetroFramework.Controls.MetroButton Load;
        private MetroFramework.Controls.MetroRadioButton Hopfield;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroButton Learn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton Result;
        private MetroFramework.Controls.MetroPanel metroPanel3;
    }
}

