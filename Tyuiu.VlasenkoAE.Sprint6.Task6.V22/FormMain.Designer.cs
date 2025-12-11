namespace Tyuiu.VlasenkoAE.Sprint6.Task6.V22
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCond_VAE = new GroupBox();
            textBoxCond_VAE = new TextBox();
            openFileDialogTask_VAE = new OpenFileDialog();
            panelTop_VAE = new Panel();
            buttonHelp_VAE = new Button();
            buttonRun_VAE = new Button();
            buttonOpen_VAE = new Button();
            panel2 = new Panel();
            groupBoxInput_VAE = new GroupBox();
            textBoxIn_VAE = new TextBox();
            panel3 = new Panel();
            groupBoxOutput_VAE = new GroupBox();
            textBoxOut_VAE = new TextBox();
            splitterInput_VAE = new Splitter();
            toolTipOpen_VAE = new ToolTip(components);
            groupBoxCond_VAE.SuspendLayout();
            panelTop_VAE.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxInput_VAE.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOutput_VAE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCond_VAE
            // 
            groupBoxCond_VAE.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBoxCond_VAE.Controls.Add(textBoxCond_VAE);
            groupBoxCond_VAE.Location = new Point(8, 68);
            groupBoxCond_VAE.Name = "groupBoxCond_VAE";
            groupBoxCond_VAE.Size = new Size(1007, 105);
            groupBoxCond_VAE.TabIndex = 0;
            groupBoxCond_VAE.TabStop = false;
            groupBoxCond_VAE.Text = "Условие:";
            // 
            // textBoxCond_VAE
            // 
            textBoxCond_VAE.Dock = DockStyle.Fill;
            textBoxCond_VAE.Location = new Point(3, 23);
            textBoxCond_VAE.Multiline = true;
            textBoxCond_VAE.Name = "textBoxCond_VAE";
            textBoxCond_VAE.Size = new Size(1001, 79);
            textBoxCond_VAE.TabIndex = 0;
            textBoxCond_VAE.Text = resources.GetString("textBoxCond_VAE.Text");
            // 
            // openFileDialogTask_VAE
            // 
            openFileDialogTask_VAE.FileName = "openFileDialogTask";
            // 
            // panelTop_VAE
            // 
            panelTop_VAE.Controls.Add(buttonHelp_VAE);
            panelTop_VAE.Controls.Add(buttonRun_VAE);
            panelTop_VAE.Controls.Add(buttonOpen_VAE);
            panelTop_VAE.Controls.Add(groupBoxCond_VAE);
            panelTop_VAE.Dock = DockStyle.Top;
            panelTop_VAE.Location = new Point(0, 0);
            panelTop_VAE.Name = "panelTop_VAE";
            panelTop_VAE.Size = new Size(1027, 185);
            panelTop_VAE.TabIndex = 3;
            // 
            // buttonHelp_VAE
            // 
            buttonHelp_VAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_VAE.Image = (Image)resources.GetObject("buttonHelp_VAE.Image");
            buttonHelp_VAE.Location = new Point(853, 13);
            buttonHelp_VAE.Name = "buttonHelp_VAE";
            buttonHelp_VAE.Size = new Size(162, 49);
            buttonHelp_VAE.TabIndex = 3;
            toolTipOpen_VAE.SetToolTip(buttonHelp_VAE, "Справка\r\n");
            buttonHelp_VAE.UseVisualStyleBackColor = true;
            buttonHelp_VAE.Click += buttonHelp_Click;
            // 
            // buttonRun_VAE
            // 
            buttonRun_VAE.Image = (Image)resources.GetObject("buttonRun_VAE.Image");
            buttonRun_VAE.Location = new Point(208, 13);
            buttonRun_VAE.Name = "buttonRun_VAE";
            buttonRun_VAE.Size = new Size(162, 49);
            buttonRun_VAE.TabIndex = 2;
            toolTipOpen_VAE.SetToolTip(buttonRun_VAE, "Выполнить\r\n");
            buttonRun_VAE.UseVisualStyleBackColor = true;
            buttonRun_VAE.Click += buttonRun_Click;
            // 
            // buttonOpen_VAE
            // 
            buttonOpen_VAE.Image = (Image)resources.GetObject("buttonOpen_VAE.Image");
            buttonOpen_VAE.Location = new Point(11, 13);
            buttonOpen_VAE.Name = "buttonOpen_VAE";
            buttonOpen_VAE.Size = new Size(178, 49);
            buttonOpen_VAE.TabIndex = 1;
            toolTipOpen_VAE.SetToolTip(buttonOpen_VAE, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_VAE.UseVisualStyleBackColor = true;
            buttonOpen_VAE.Click += buttonOpen_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxInput_VAE);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 304);
            panel2.TabIndex = 4;
            // 
            // groupBoxInput_VAE
            // 
            groupBoxInput_VAE.Controls.Add(textBoxIn_VAE);
            groupBoxInput_VAE.Dock = DockStyle.Fill;
            groupBoxInput_VAE.Location = new Point(0, 0);
            groupBoxInput_VAE.Name = "groupBoxInput_VAE";
            groupBoxInput_VAE.Size = new Size(505, 304);
            groupBoxInput_VAE.TabIndex = 0;
            groupBoxInput_VAE.TabStop = false;
            groupBoxInput_VAE.Text = "Ввод";
            // 
            // textBoxIn_VAE
            // 
            textBoxIn_VAE.Dock = DockStyle.Fill;
            textBoxIn_VAE.Location = new Point(3, 23);
            textBoxIn_VAE.Multiline = true;
            textBoxIn_VAE.Name = "textBoxIn_VAE";
            textBoxIn_VAE.ScrollBars = ScrollBars.Vertical;
            textBoxIn_VAE.Size = new Size(499, 278);
            textBoxIn_VAE.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxOutput_VAE);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(511, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(516, 304);
            panel3.TabIndex = 5;
            // 
            // groupBoxOutput_VAE
            // 
            groupBoxOutput_VAE.Controls.Add(textBoxOut_VAE);
            groupBoxOutput_VAE.Dock = DockStyle.Fill;
            groupBoxOutput_VAE.Location = new Point(0, 0);
            groupBoxOutput_VAE.Name = "groupBoxOutput_VAE";
            groupBoxOutput_VAE.Size = new Size(516, 304);
            groupBoxOutput_VAE.TabIndex = 0;
            groupBoxOutput_VAE.TabStop = false;
            groupBoxOutput_VAE.Text = "Вывод";
            // 
            // textBoxOut_VAE
            // 
            textBoxOut_VAE.Dock = DockStyle.Fill;
            textBoxOut_VAE.Location = new Point(3, 23);
            textBoxOut_VAE.Multiline = true;
            textBoxOut_VAE.Name = "textBoxOut_VAE";
            textBoxOut_VAE.Size = new Size(510, 278);
            textBoxOut_VAE.TabIndex = 0;
            // 
            // splitterInput_VAE
            // 
            splitterInput_VAE.Location = new Point(505, 185);
            splitterInput_VAE.Name = "splitterInput_VAE";
            splitterInput_VAE.Size = new Size(10, 304);
            splitterInput_VAE.TabIndex = 6;
            splitterInput_VAE.TabStop = false;
            // 
            // toolTipOpen_VAE
            // 
            toolTipOpen_VAE.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpen_VAE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 489);
            Controls.Add(splitterInput_VAE);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelTop_VAE);
            MinimumSize = new Size(1045, 536);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Власенко А. Е.";
            Load += Form1_Load;
            groupBoxCond_VAE.ResumeLayout(false);
            groupBoxCond_VAE.PerformLayout();
            panelTop_VAE.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxInput_VAE.ResumeLayout(false);
            groupBoxInput_VAE.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxOutput_VAE.ResumeLayout(false);
            groupBoxOutput_VAE.PerformLayout();
            ResumeLayout(false);
        }

        private void ButtonHelp_VAE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonRun_VAE_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxCond_VAE;
        private TextBox textBoxCond_VAE;
        private OpenFileDialog openFileDialogTask_VAE;
        private Panel panelTop_VAE;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitterInput_VAE;
        private GroupBox groupBoxInput_VAE;
        private TextBox textBoxIn_VAE;
        private GroupBox groupBoxOutput_VAE;
        private TextBox textBoxOut_VAE;
        private Button buttonHelp_VAE;
        private Button buttonRun_VAE;
        private Button buttonOpen_VAE;
        private ToolTip toolTipOpen_VAE;
    }
}
