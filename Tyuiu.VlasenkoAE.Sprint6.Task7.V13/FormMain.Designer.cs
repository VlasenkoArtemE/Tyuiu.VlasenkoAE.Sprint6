namespace Tyuiu.VlasenkoAE.Sprint6.Task7.V13
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
            panelButton_VAE = new Panel();
            buttonSave_VAE = new Button();
            buttonInfo_VAE = new Button();
            buttonRun_VAE = new Button();
            buttonOpen_VAE = new Button();
            splitContainerDown_VAE = new SplitContainer();
            groupBoxInput_VAE = new GroupBox();
            dataGridViewIn_VAE = new DataGridView();
            groupBoxOutput_VAE = new GroupBox();
            dataGridViewOut_VAE = new DataGridView();
            panelCond_VAE = new Panel();
            groupBoxCond_VAE = new GroupBox();
            textBoxCond_VAE = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            toolTipButton = new ToolTip(components);
            panelButton_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerDown_VAE).BeginInit();
            splitContainerDown_VAE.Panel1.SuspendLayout();
            splitContainerDown_VAE.Panel2.SuspendLayout();
            splitContainerDown_VAE.SuspendLayout();
            groupBoxInput_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_VAE).BeginInit();
            groupBoxOutput_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_VAE).BeginInit();
            panelCond_VAE.SuspendLayout();
            groupBoxCond_VAE.SuspendLayout();
            SuspendLayout();
            // 
            // panelButton_VAE
            // 
            panelButton_VAE.Controls.Add(buttonSave_VAE);
            panelButton_VAE.Controls.Add(buttonInfo_VAE);
            panelButton_VAE.Controls.Add(buttonRun_VAE);
            panelButton_VAE.Controls.Add(buttonOpen_VAE);
            panelButton_VAE.Dock = DockStyle.Top;
            panelButton_VAE.Location = new Point(0, 0);
            panelButton_VAE.Name = "panelButton_VAE";
            panelButton_VAE.Size = new Size(1015, 102);
            panelButton_VAE.TabIndex = 0;
            // 
            // buttonSave_VAE
            // 
            buttonSave_VAE.Image = (Image)resources.GetObject("buttonSave_VAE.Image");
            buttonSave_VAE.Location = new Point(324, 10);
            buttonSave_VAE.Name = "buttonSave_VAE";
            buttonSave_VAE.Size = new Size(146, 83);
            buttonSave_VAE.TabIndex = 3;
            toolTipButton.SetToolTip(buttonSave_VAE, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_VAE.UseVisualStyleBackColor = true;
            buttonSave_VAE.Click += buttonSave_VAE_Click;
            buttonSave_VAE.MouseEnter += buttonSave_VAE_MouseEnter;
            // 
            // buttonInfo_VAE
            // 
            buttonInfo_VAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_VAE.Image = (Image)resources.GetObject("buttonInfo_VAE.Image");
            buttonInfo_VAE.Location = new Point(869, 10);
            buttonInfo_VAE.Name = "buttonInfo_VAE";
            buttonInfo_VAE.Size = new Size(134, 83);
            buttonInfo_VAE.TabIndex = 2;
            toolTipButton.SetToolTip(buttonInfo_VAE, "Сведения о программе");
            buttonInfo_VAE.UseVisualStyleBackColor = true;
            buttonInfo_VAE.Click += buttonInfo_VAE_Click;
            buttonInfo_VAE.MouseEnter += buttonInfo_VAE_MouseEnter;
            // 
            // buttonRun_VAE
            // 
            buttonRun_VAE.Image = (Image)resources.GetObject("buttonRun_VAE.Image");
            buttonRun_VAE.Location = new Point(166, 10);
            buttonRun_VAE.Name = "buttonRun_VAE";
            buttonRun_VAE.Size = new Size(143, 83);
            buttonRun_VAE.TabIndex = 1;
            toolTipButton.SetToolTip(buttonRun_VAE, "Выполнить обработку данных");
            buttonRun_VAE.UseVisualStyleBackColor = true;
            buttonRun_VAE.Click += buttonRun_VAE_Click;
            buttonRun_VAE.MouseEnter += buttonRun_VAE_MouseEnter;
            // 
            // buttonOpen_VAE
            // 
            buttonOpen_VAE.Image = (Image)resources.GetObject("buttonOpen_VAE.Image");
            buttonOpen_VAE.Location = new Point(9, 10);
            buttonOpen_VAE.Name = "buttonOpen_VAE";
            buttonOpen_VAE.Size = new Size(141, 83);
            buttonOpen_VAE.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpen_VAE, "Открыть файл для обработки данных в фомате CSV");
            buttonOpen_VAE.UseVisualStyleBackColor = true;
            buttonOpen_VAE.Click += buttonOpen_VAE_Click;
            buttonOpen_VAE.MouseEnter += buttonOpen_VAE_MouseEnter;
            // 
            // splitContainerDown_VAE
            // 
            splitContainerDown_VAE.Dock = DockStyle.Bottom;
            splitContainerDown_VAE.Location = new Point(0, 205);
            splitContainerDown_VAE.Name = "splitContainerDown_VAE";
            // 
            // splitContainerDown_VAE.Panel1
            // 
            splitContainerDown_VAE.Panel1.Controls.Add(groupBoxInput_VAE);
            // 
            // splitContainerDown_VAE.Panel2
            // 
            splitContainerDown_VAE.Panel2.Controls.Add(groupBoxOutput_VAE);
            splitContainerDown_VAE.Size = new Size(1015, 297);
            splitContainerDown_VAE.SplitterDistance = 491;
            splitContainerDown_VAE.TabIndex = 1;
            // 
            // groupBoxInput_VAE
            // 
            groupBoxInput_VAE.Controls.Add(dataGridViewIn_VAE);
            groupBoxInput_VAE.Dock = DockStyle.Fill;
            groupBoxInput_VAE.Location = new Point(0, 0);
            groupBoxInput_VAE.Name = "groupBoxInput_VAE";
            groupBoxInput_VAE.Size = new Size(491, 297);
            groupBoxInput_VAE.TabIndex = 0;
            groupBoxInput_VAE.TabStop = false;
            groupBoxInput_VAE.Text = "Ввод:";
            // 
            // dataGridViewIn_VAE
            // 
            dataGridViewIn_VAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_VAE.Dock = DockStyle.Fill;
            dataGridViewIn_VAE.Location = new Point(3, 23);
            dataGridViewIn_VAE.Name = "dataGridViewIn_VAE";
            dataGridViewIn_VAE.RowHeadersWidth = 51;
            dataGridViewIn_VAE.Size = new Size(485, 271);
            dataGridViewIn_VAE.TabIndex = 0;
            // 
            // groupBoxOutput_VAE
            // 
            groupBoxOutput_VAE.Controls.Add(dataGridViewOut_VAE);
            groupBoxOutput_VAE.Dock = DockStyle.Fill;
            groupBoxOutput_VAE.Location = new Point(0, 0);
            groupBoxOutput_VAE.Name = "groupBoxOutput_VAE";
            groupBoxOutput_VAE.Size = new Size(520, 297);
            groupBoxOutput_VAE.TabIndex = 0;
            groupBoxOutput_VAE.TabStop = false;
            groupBoxOutput_VAE.Text = "Вывод:";
            // 
            // dataGridViewOut_VAE
            // 
            dataGridViewOut_VAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_VAE.Dock = DockStyle.Fill;
            dataGridViewOut_VAE.Location = new Point(3, 23);
            dataGridViewOut_VAE.Name = "dataGridViewOut_VAE";
            dataGridViewOut_VAE.RowHeadersWidth = 51;
            dataGridViewOut_VAE.Size = new Size(514, 271);
            dataGridViewOut_VAE.TabIndex = 0;
            // 
            // panelCond_VAE
            // 
            panelCond_VAE.Controls.Add(groupBoxCond_VAE);
            panelCond_VAE.Dock = DockStyle.Fill;
            panelCond_VAE.Location = new Point(0, 102);
            panelCond_VAE.Name = "panelCond_VAE";
            panelCond_VAE.Size = new Size(1015, 103);
            panelCond_VAE.TabIndex = 2;
            // 
            // groupBoxCond_VAE
            // 
            groupBoxCond_VAE.Controls.Add(textBoxCond_VAE);
            groupBoxCond_VAE.Dock = DockStyle.Fill;
            groupBoxCond_VAE.Location = new Point(0, 0);
            groupBoxCond_VAE.Name = "groupBoxCond_VAE";
            groupBoxCond_VAE.Size = new Size(1015, 103);
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
            textBoxCond_VAE.Size = new Size(1009, 77);
            textBoxCond_VAE.TabIndex = 0;
            textBoxCond_VAE.Text = resources.GetString("textBoxCond_VAE.Text");
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 502);
            Controls.Add(panelCond_VAE);
            Controls.Add(splitContainerDown_VAE);
            Controls.Add(panelButton_VAE);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Власенко А. Е.";
            panelButton_VAE.ResumeLayout(false);
            splitContainerDown_VAE.Panel1.ResumeLayout(false);
            splitContainerDown_VAE.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerDown_VAE).EndInit();
            splitContainerDown_VAE.ResumeLayout(false);
            groupBoxInput_VAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_VAE).EndInit();
            groupBoxOutput_VAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_VAE).EndInit();
            panelCond_VAE.ResumeLayout(false);
            groupBoxCond_VAE.ResumeLayout(false);
            groupBoxCond_VAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_VAE;
        private SplitContainer splitContainerDown_VAE;
        private GroupBox groupBoxInput_VAE;
        private GroupBox groupBoxOutput_VAE;
        private Panel panelCond_VAE;
        private GroupBox groupBoxCond_VAE;
        private TextBox textBoxCond_VAE;
        private Button buttonSave_VAE;
        private Button buttonInfo_VAE;
        private Button buttonRun_VAE;
        private Button buttonOpen_VAE;
        private DataGridView dataGridViewIn_VAE;
        private DataGridView dataGridViewOut_VAE;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private ToolTip toolTipButton;
    }
}
