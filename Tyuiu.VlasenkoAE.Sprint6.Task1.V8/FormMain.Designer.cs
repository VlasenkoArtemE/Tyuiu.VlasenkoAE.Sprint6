namespace Tyuiu.VlasenkoAE.Sprint6.Task1.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCond_VAE = new GroupBox();
            pictureBoxCond_VAE = new PictureBox();
            groupBoxRes_VAE = new GroupBox();
            textBoxRes_VAE = new TextBox();
            groupBoxInput_VAE = new GroupBox();
            textBoxStop_VAE = new TextBox();
            textBoxStart_VAE = new TextBox();
            buttonInfo_VAE = new Button();
            buttonRun_VAE = new Button();
            groupBoxStart_VAE = new GroupBox();
            groupBoxStop_VAE = new GroupBox();
            groupBoxCond_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCond_VAE).BeginInit();
            groupBoxRes_VAE.SuspendLayout();
            groupBoxInput_VAE.SuspendLayout();
            groupBoxStart_VAE.SuspendLayout();
            groupBoxStop_VAE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCond_VAE
            // 
            groupBoxCond_VAE.Controls.Add(pictureBoxCond_VAE);
            groupBoxCond_VAE.Location = new Point(20, 19);
            groupBoxCond_VAE.Name = "groupBoxCond_VAE";
            groupBoxCond_VAE.Size = new Size(682, 264);
            groupBoxCond_VAE.TabIndex = 0;
            groupBoxCond_VAE.TabStop = false;
            groupBoxCond_VAE.Text = "Условие";
            // 
            // pictureBoxCond_VAE
            // 
            pictureBoxCond_VAE.ImageLocation = "C:\\Users\\artem\\source\\repos\\Tyuiu.VlasenkoAE.Sprint6\\Image\\УсловиеTask1.png";
            pictureBoxCond_VAE.Location = new Point(16, 32);
            pictureBoxCond_VAE.Name = "pictureBoxCond_VAE";
            pictureBoxCond_VAE.Size = new Size(636, 209);
            pictureBoxCond_VAE.TabIndex = 0;
            pictureBoxCond_VAE.TabStop = false;
            // 
            // groupBoxRes_VAE
            // 
            groupBoxRes_VAE.Controls.Add(textBoxRes_VAE);
            groupBoxRes_VAE.Location = new Point(727, 19);
            groupBoxRes_VAE.Name = "groupBoxRes_VAE";
            groupBoxRes_VAE.Size = new Size(269, 410);
            groupBoxRes_VAE.TabIndex = 1;
            groupBoxRes_VAE.TabStop = false;
            groupBoxRes_VAE.Text = "Вывод данных";
            // 
            // textBoxRes_VAE
            // 
            textBoxRes_VAE.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_VAE.Location = new Point(13, 26);
            textBoxRes_VAE.Multiline = true;
            textBoxRes_VAE.Name = "textBoxRes_VAE";
            textBoxRes_VAE.ReadOnly = true;
            textBoxRes_VAE.ScrollBars = ScrollBars.Vertical;
            textBoxRes_VAE.Size = new Size(245, 378);
            textBoxRes_VAE.TabIndex = 0;
            // 
            // groupBoxInput_VAE
            // 
            groupBoxInput_VAE.Controls.Add(groupBoxStop_VAE);
            groupBoxInput_VAE.Controls.Add(groupBoxStart_VAE);
            groupBoxInput_VAE.Location = new Point(20, 304);
            groupBoxInput_VAE.Name = "groupBoxInput_VAE";
            groupBoxInput_VAE.Size = new Size(311, 125);
            groupBoxInput_VAE.TabIndex = 2;
            groupBoxInput_VAE.TabStop = false;
            groupBoxInput_VAE.Text = "Ввод данных";
            // 
            // textBoxStop_VAE
            // 
            textBoxStop_VAE.Location = new Point(6, 26);
            textBoxStop_VAE.Multiline = true;
            textBoxStop_VAE.Name = "textBoxStop_VAE";
            textBoxStop_VAE.Size = new Size(104, 26);
            textBoxStop_VAE.TabIndex = 1;
            // 
            // textBoxStart_VAE
            // 
            textBoxStart_VAE.Location = new Point(10, 26);
            textBoxStart_VAE.Multiline = true;
            textBoxStart_VAE.Name = "textBoxStart_VAE";
            textBoxStart_VAE.Size = new Size(115, 27);
            textBoxStart_VAE.TabIndex = 0;
            // 
            // buttonInfo_VAE
            // 
            buttonInfo_VAE.BackColor = Color.FromArgb(128, 255, 255);
            buttonInfo_VAE.Location = new Point(396, 350);
            buttonInfo_VAE.Name = "buttonInfo_VAE";
            buttonInfo_VAE.Size = new Size(128, 79);
            buttonInfo_VAE.TabIndex = 3;
            buttonInfo_VAE.Text = "Справка";
            buttonInfo_VAE.UseVisualStyleBackColor = false;
            buttonInfo_VAE.Click += buttonInfo_Click;
            // 
            // buttonRun_VAE
            // 
            buttonRun_VAE.BackColor = Color.FromArgb(128, 255, 128);
            buttonRun_VAE.Location = new Point(543, 350);
            buttonRun_VAE.Name = "buttonRun_VAE";
            buttonRun_VAE.Size = new Size(159, 79);
            buttonRun_VAE.TabIndex = 4;
            buttonRun_VAE.Text = "Выполнить";
            buttonRun_VAE.UseVisualStyleBackColor = false;
            buttonRun_VAE.Click += buttonRun_Click;
            // 
            // groupBoxStart_VAE
            // 
            groupBoxStart_VAE.Controls.Add(textBoxStart_VAE);
            groupBoxStart_VAE.Location = new Point(16, 46);
            groupBoxStart_VAE.Name = "groupBoxStart_VAE";
            groupBoxStart_VAE.Size = new Size(133, 58);
            groupBoxStart_VAE.TabIndex = 2;
            groupBoxStart_VAE.TabStop = false;
            groupBoxStart_VAE.Text = "Старт шага:";
            // 
            // groupBoxStop_VAE
            // 
            groupBoxStop_VAE.Controls.Add(textBoxStop_VAE);
            groupBoxStop_VAE.Location = new Point(179, 46);
            groupBoxStop_VAE.Name = "groupBoxStop_VAE";
            groupBoxStop_VAE.Size = new Size(116, 58);
            groupBoxStop_VAE.TabIndex = 3;
            groupBoxStop_VAE.TabStop = false;
            groupBoxStop_VAE.Text = "Конец шага:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 450);
            Controls.Add(buttonRun_VAE);
            Controls.Add(buttonInfo_VAE);
            Controls.Add(groupBoxInput_VAE);
            Controls.Add(groupBoxRes_VAE);
            Controls.Add(groupBoxCond_VAE);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Власенко А. Е.";
            groupBoxCond_VAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCond_VAE).EndInit();
            groupBoxRes_VAE.ResumeLayout(false);
            groupBoxRes_VAE.PerformLayout();
            groupBoxInput_VAE.ResumeLayout(false);
            groupBoxStart_VAE.ResumeLayout(false);
            groupBoxStart_VAE.PerformLayout();
            groupBoxStop_VAE.ResumeLayout(false);
            groupBoxStop_VAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_VAE;
        private PictureBox pictureBoxCond_VAE;
        private GroupBox groupBoxRes_VAE;
        private TextBox textBoxRes_VAE;
        private GroupBox groupBoxInput_VAE;
        private TextBox textBoxStop_VAE;
        private TextBox textBoxStart_VAE;
        private Button buttonInfo_VAE;
        private Button buttonRun_VAE;
        private GroupBox groupBoxStart_VAE;
        private GroupBox groupBoxStop_VAE;
    }
}
