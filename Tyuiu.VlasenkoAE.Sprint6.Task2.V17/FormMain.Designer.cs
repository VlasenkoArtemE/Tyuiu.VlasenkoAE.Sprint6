namespace Tyuiu.VlasenkoAE.Sprint6.Task2.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCond_VAE = new GroupBox();
            pictureBoxCond_VAE = new PictureBox();
            groupBoxOutput_VAE = new GroupBox();
            chartFunction_VAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_VAE = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            groupBoxInput_VAE = new GroupBox();
            groupBoxStop_VAE = new GroupBox();
            textBoxStop_VAE = new TextBox();
            groupBoxStart_VAE = new GroupBox();
            textBoxStart_VAE = new TextBox();
            buttonRun_VAE = new Button();
            buttonInfo_VAE = new Button();
            groupBoxCond_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCond_VAE).BeginInit();
            groupBoxOutput_VAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_VAE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VAE).BeginInit();
            groupBoxInput_VAE.SuspendLayout();
            groupBoxStop_VAE.SuspendLayout();
            groupBoxStart_VAE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCond_VAE
            // 
            groupBoxCond_VAE.Controls.Add(pictureBoxCond_VAE);
            groupBoxCond_VAE.Location = new Point(9, 11);
            groupBoxCond_VAE.Name = "groupBoxCond_VAE";
            groupBoxCond_VAE.Size = new Size(659, 255);
            groupBoxCond_VAE.TabIndex = 0;
            groupBoxCond_VAE.TabStop = false;
            groupBoxCond_VAE.Text = "Условие";
            // 
            // pictureBoxCond_VAE
            // 
            pictureBoxCond_VAE.ImageLocation = "C:\\Users\\artem\\source\\repos\\Tyuiu.VlasenkoAE.Sprint6\\Image\\ConditionTask2.png";
            pictureBoxCond_VAE.Location = new Point(10, 31);
            pictureBoxCond_VAE.Name = "pictureBoxCond_VAE";
            pictureBoxCond_VAE.Size = new Size(638, 213);
            pictureBoxCond_VAE.TabIndex = 0;
            pictureBoxCond_VAE.TabStop = false;
            // 
            // groupBoxOutput_VAE
            // 
            groupBoxOutput_VAE.Controls.Add(chartFunction_VAE);
            groupBoxOutput_VAE.Controls.Add(dataGridViewFunction_VAE);
            groupBoxOutput_VAE.Location = new Point(690, 12);
            groupBoxOutput_VAE.Name = "groupBoxOutput_VAE";
            groupBoxOutput_VAE.Size = new Size(754, 419);
            groupBoxOutput_VAE.TabIndex = 1;
            groupBoxOutput_VAE.TabStop = false;
            groupBoxOutput_VAE.Text = "Вывод данных";
            // 
            // chartFunction_VAE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_VAE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_VAE.Legends.Add(legend1);
            chartFunction_VAE.Location = new Point(186, 46);
            chartFunction_VAE.Name = "chartFunction_VAE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_VAE.Series.Add(series1);
            chartFunction_VAE.Size = new Size(542, 359);
            chartFunction_VAE.TabIndex = 1;
            chartFunction_VAE.Text = "chartFunction";
            // 
            // dataGridViewFunction_VAE
            // 
            dataGridViewFunction_VAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_VAE.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction_VAE.Location = new Point(15, 43);
            dataGridViewFunction_VAE.Name = "dataGridViewFunction_VAE";
            dataGridViewFunction_VAE.RowHeadersVisible = false;
            dataGridViewFunction_VAE.RowHeadersWidth = 51;
            dataGridViewFunction_VAE.Size = new Size(142, 364);
            dataGridViewFunction_VAE.TabIndex = 0;
            dataGridViewFunction_VAE.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 70;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.Width = 70;
            // 
            // groupBoxInput_VAE
            // 
            groupBoxInput_VAE.Controls.Add(groupBoxStop_VAE);
            groupBoxInput_VAE.Controls.Add(groupBoxStart_VAE);
            groupBoxInput_VAE.Location = new Point(19, 327);
            groupBoxInput_VAE.Name = "groupBoxInput_VAE";
            groupBoxInput_VAE.Size = new Size(308, 106);
            groupBoxInput_VAE.TabIndex = 2;
            groupBoxInput_VAE.TabStop = false;
            groupBoxInput_VAE.Text = "Ввод данных";
            // 
            // groupBoxStop_VAE
            // 
            groupBoxStop_VAE.Controls.Add(textBoxStop_VAE);
            groupBoxStop_VAE.Location = new Point(169, 36);
            groupBoxStop_VAE.Name = "groupBoxStop_VAE";
            groupBoxStop_VAE.Size = new Size(120, 59);
            groupBoxStop_VAE.TabIndex = 1;
            groupBoxStop_VAE.TabStop = false;
            groupBoxStop_VAE.Text = "Конец шага:";
            // 
            // textBoxStop_VAE
            // 
            textBoxStop_VAE.Location = new Point(6, 26);
            textBoxStop_VAE.Name = "textBoxStop_VAE";
            textBoxStop_VAE.Size = new Size(107, 27);
            textBoxStop_VAE.TabIndex = 0;
            // 
            // groupBoxStart_VAE
            // 
            groupBoxStart_VAE.Controls.Add(textBoxStart_VAE);
            groupBoxStart_VAE.Location = new Point(12, 36);
            groupBoxStart_VAE.Name = "groupBoxStart_VAE";
            groupBoxStart_VAE.Size = new Size(134, 59);
            groupBoxStart_VAE.TabIndex = 0;
            groupBoxStart_VAE.TabStop = false;
            groupBoxStart_VAE.Text = "Старт шага:";
            // 
            // textBoxStart_VAE
            // 
            textBoxStart_VAE.Location = new Point(11, 27);
            textBoxStart_VAE.Name = "textBoxStart_VAE";
            textBoxStart_VAE.Size = new Size(114, 27);
            textBoxStart_VAE.TabIndex = 0;
            // 
            // buttonRun_VAE
            // 
            buttonRun_VAE.BackColor = Color.FromArgb(128, 255, 128);
            buttonRun_VAE.Location = new Point(485, 340);
            buttonRun_VAE.Name = "buttonRun_VAE";
            buttonRun_VAE.Size = new Size(183, 91);
            buttonRun_VAE.TabIndex = 3;
            buttonRun_VAE.Text = "Выполнить";
            buttonRun_VAE.UseVisualStyleBackColor = false;
            buttonRun_VAE.MouseDown += buttonRunDown_VAE;
            buttonRun_VAE.MouseEnter += buttonRunEnter_VAE;
            buttonRun_VAE.MouseLeave += buttonRunLeave_VAE;
            buttonRun_VAE.Click += buttonRun_Click;
            // 
            // buttonInfo_VAE
            // 
            buttonInfo_VAE.BackColor = Color.FromArgb(128, 255, 255);
            buttonInfo_VAE.Location = new Point(370, 340);
            buttonInfo_VAE.Name = "buttonInfo_VAE";
            buttonInfo_VAE.Size = new Size(95, 91);
            buttonInfo_VAE.TabIndex = 4;
            buttonInfo_VAE.Text = "Справка";
            buttonInfo_VAE.UseVisualStyleBackColor = false;
            buttonInfo_VAE.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 450);
            Controls.Add(buttonInfo_VAE);
            Controls.Add(buttonRun_VAE);
            Controls.Add(groupBoxInput_VAE);
            Controls.Add(groupBoxOutput_VAE);
            Controls.Add(groupBoxCond_VAE);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Власенко А. Е.";
            groupBoxCond_VAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCond_VAE).EndInit();
            groupBoxOutput_VAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_VAE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_VAE).EndInit();
            groupBoxInput_VAE.ResumeLayout(false);
            groupBoxStop_VAE.ResumeLayout(false);
            groupBoxStop_VAE.PerformLayout();
            groupBoxStart_VAE.ResumeLayout(false);
            groupBoxStart_VAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCond_VAE;
        private PictureBox pictureBoxCond_VAE;
        private GroupBox groupBoxOutput_VAE;
        private GroupBox groupBoxInput_VAE;
        private GroupBox groupBoxStop_VAE;
        private TextBox textBoxStop_VAE;
        private GroupBox groupBoxStart_VAE;
        private TextBox textBoxStart_VAE;
        private Button buttonRun_VAE;
        private Button buttonInfo_VAE;
        private DataGridView dataGridViewFunction_VAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_VAE;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
    }
}
