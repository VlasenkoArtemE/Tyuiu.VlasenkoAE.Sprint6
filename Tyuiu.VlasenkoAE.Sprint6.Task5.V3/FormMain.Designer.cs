using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.VlasenkoAE.Sprint6.Task5.V3
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonLoad;
        private DataGridView dataGridViewValues;
        private PictureBox pictureBoxChart;
        private Label labelGrid;
        private Label labelChart;
        private Button buttonInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonLoad = new Button();
            dataGridViewValues = new DataGridView();
            pictureBoxChart = new PictureBox();
            labelGrid = new Label();
            labelChart = new Label();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).BeginInit();
            SuspendLayout();
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(20, 20);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(180, 35);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить данные";
            buttonLoad.Click += buttonLoad_Click;
            // 
            // dataGridViewValues
            // 
            dataGridViewValues.AllowUserToAddRows = false;
            dataGridViewValues.AllowUserToDeleteRows = false;
            dataGridViewValues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewValues.Location = new Point(20, 90);
            dataGridViewValues.Name = "dataGridViewValues";
            dataGridViewValues.ReadOnly = true;
            dataGridViewValues.RowHeadersVisible = false;
            dataGridViewValues.RowHeadersWidth = 51;
            dataGridViewValues.Size = new Size(300, 350);
            dataGridViewValues.TabIndex = 3;
            // 
            // pictureBoxChart
            // 
            pictureBoxChart.BackColor = Color.White;
            pictureBoxChart.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxChart.Location = new Point(340, 90);
            pictureBoxChart.Name = "pictureBoxChart";
            pictureBoxChart.Size = new Size(691, 350);
            pictureBoxChart.TabIndex = 5;
            pictureBoxChart.TabStop = false;
            pictureBoxChart.Paint += pictureBoxChart_Paint;
            // 
            // labelGrid
            // 
            labelGrid.AutoSize = true;
            labelGrid.Location = new Point(20, 65);
            labelGrid.Name = "labelGrid";
            labelGrid.Size = new Size(210, 20);
            labelGrid.TabIndex = 2;
            labelGrid.Text = "Значения из файла (%1 != 0):";
            // 
            // labelChart
            // 
            labelChart.AutoSize = true;
            labelChart.Location = new Point(340, 65);
            labelChart.Name = "labelChart";
            labelChart.Size = new Size(160, 20);
            labelChart.TabIndex = 4;
            labelChart.Text = "Диаграмма значений";
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(210, 20);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(110, 35);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Информация";
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(1068, 460);
            Controls.Add(buttonLoad);
            Controls.Add(buttonInfo);
            Controls.Add(labelGrid);
            Controls.Add(dataGridViewValues);
            Controls.Add(labelChart);
            Controls.Add(pictureBoxChart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 3 | Власенко А. Е.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewValues).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

