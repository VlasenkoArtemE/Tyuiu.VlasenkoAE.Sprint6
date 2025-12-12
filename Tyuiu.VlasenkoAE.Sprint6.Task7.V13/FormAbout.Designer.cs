namespace Tyuiu.VlasenkoAE.Sprint6.Task7.V13
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
            buttonClose_VAE = new Button();
            SuspendLayout();
            // 
            // textBoxInfo_VAE
            // 
            textBoxInfo_VAE.Dock = DockStyle.Top;
            textBoxInfo_VAE.Location = new Point(0, 0);
            textBoxInfo_VAE.Multiline = true;
            textBoxInfo_VAE.Name = "textBoxInfo_VAE";
            textBoxInfo_VAE.Size = new Size(672, 151);
            textBoxInfo_VAE.TabIndex = 0;
            textBoxInfo_VAE.Text = "Разработчик: Власенко А. Е.\r\nГруппа: ИСТНб-25-1";
            // 
            // buttonClose_VAE
            // 
            buttonClose_VAE.Location = new Point(545, 167);
            buttonClose_VAE.Name = "buttonClose_VAE";
            buttonClose_VAE.Size = new Size(110, 39);
            buttonClose_VAE.TabIndex = 1;
            buttonClose_VAE.Text = "Ok";
            buttonClose_VAE.UseVisualStyleBackColor = true;
            buttonClose_VAE.Click += buttonClose_VAE_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 217);
            Controls.Add(buttonClose_VAE);
            Controls.Add(textBoxInfo_VAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_VAE;
        private Button buttonClose_VAE;
    }
}