namespace Tyuiu.VlasenkoAE.Sprint6.Task6.V22
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInfo_VAE = new TextBox();
            SuspendLayout();
            // 
            // textBoxInfo_VAE
            // 
            textBoxInfo_VAE.Location = new Point(16, 13);
            textBoxInfo_VAE.Multiline = true;
            textBoxInfo_VAE.Name = "textBoxInfo_VAE";
            textBoxInfo_VAE.Size = new Size(526, 150);
            textBoxInfo_VAE.TabIndex = 0;
            textBoxInfo_VAE.Text = "Разработчик: Власенко Артём Евгеньевич\r\nГруппа: ИСТНб-25-1\r\n";
            textBoxInfo_VAE.TextChanged += textBox1_TextChanged;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 170);
            Controls.Add(textBoxInfo_VAE);
            Name = "FormAbout";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_VAE;
    }
}