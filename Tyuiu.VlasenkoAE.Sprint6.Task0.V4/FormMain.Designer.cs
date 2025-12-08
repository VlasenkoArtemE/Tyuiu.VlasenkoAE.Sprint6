using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.VlasenkoAE.Sprint6.Task0.V4
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnRun_VAE;
        private Button btnInfo_VAE;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnRun_VAE = new Button();
            btnInfo_VAE = new Button();
            pictureBoxCond_VAE = new PictureBox();
            textBoxRes_VAE = new TextBox();
            pictureBoxCon_VAE = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCond_VAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCon_VAE).BeginInit();
            SuspendLayout();
            // 
            // btnRun_VAE
            // 
            btnRun_VAE.Location = new Point(463, 305);
            btnRun_VAE.Name = "btnRun_VAE";
            btnRun_VAE.Size = new Size(131, 41);
            btnRun_VAE.TabIndex = 2;
            btnRun_VAE.Text = "Выполнить";
            btnRun_VAE.Click += buttonExecute_Click;
            // 
            // btnInfo_VAE
            // 
            btnInfo_VAE.Location = new Point(402, 305);
            btnInfo_VAE.Name = "btnInfo_VAE";
            btnInfo_VAE.Size = new Size(55, 41);
            btnInfo_VAE.TabIndex = 3;
            btnInfo_VAE.Text = "?";
            btnInfo_VAE.Click += buttonInfo_Click;
            // 
            // pictureBoxCond_VAE
            // 
            pictureBoxCond_VAE.Location = new Point(0, 0);
            pictureBoxCond_VAE.Name = "pictureBoxCond_VAE";
            pictureBoxCond_VAE.Size = new Size(100, 50);
            pictureBoxCond_VAE.TabIndex = 0;
            pictureBoxCond_VAE.TabStop = false;
            // 
            // textBoxRes_VAE
            // 
            textBoxRes_VAE.Location = new Point(316, 233);
            textBoxRes_VAE.Name = "textBoxRes_VAE";
            textBoxRes_VAE.Size = new Size(244, 27);
            textBoxRes_VAE.TabIndex = 5;
            textBoxRes_VAE.TextChanged += textBoxRes_VAE_TextChanged;
            // 
            // pictureBoxCon_VAE
            // 
            pictureBoxCon_VAE.ImageLocation = "C:\\Users\\artem\\source\\repos\\Tyuiu.VlasenkoAE.Sprint6\\Image\\УсловиеTask0.png";
            pictureBoxCon_VAE.Location = new Point(48, 47);
            pictureBoxCon_VAE.Name = "pictureBoxCon_VAE";
            pictureBoxCon_VAE.Size = new Size(512, 140);
            pictureBoxCon_VAE.TabIndex = 6;
            pictureBoxCon_VAE.TabStop = false;
            // 
            // FormMain
            // 
            ClientSize = new Size(606, 358);
            Controls.Add(pictureBoxCon_VAE);
            Controls.Add(textBoxRes_VAE);
            Controls.Add(btnRun_VAE);
            Controls.Add(btnInfo_VAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 4 | Власенко А. Е.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCond_VAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCon_VAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox textBox1;
        private PictureBox pictureBoxCond_VAE;
        private TextBox textBoxRes_VAE;
        private PictureBox pictureBoxCon_VAE;
    }
}