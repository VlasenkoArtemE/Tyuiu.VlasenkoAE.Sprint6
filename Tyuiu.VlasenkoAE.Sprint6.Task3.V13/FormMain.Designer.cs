using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.VlasenkoAE.Sprint6.Task3.V13
{
    partial class FormMain
    {
        private DataGridView dataGridViewResult_VAE;
        private Button buttonExecute_VAE;
        private Button buttonInfo_VAE;
        private Label labelTask;
        private TextBox textBoxTask_VAE;

        private void InitializeComponent()
        {
            labelTask = new Label();
            textBoxTask_VAE = new TextBox();
            dataGridViewResult_VAE = new DataGridView();
            buttonExecute_VAE = new Button();
            buttonInfo_VAE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VAE).BeginInit();
            SuspendLayout();
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(20, 10);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(70, 20);
            labelTask.TabIndex = 0;
            labelTask.Text = "Условие:";
            // 
            // textBoxTask_VAE
            // 
            textBoxTask_VAE.Location = new Point(20, 30);
            textBoxTask_VAE.Multiline = true;
            textBoxTask_VAE.Name = "textBoxTask_VAE";
            textBoxTask_VAE.ReadOnly = true;
            textBoxTask_VAE.ScrollBars = ScrollBars.Vertical;
            textBoxTask_VAE.Size = new Size(500, 215);
            textBoxTask_VAE.TabIndex = 1;
            textBoxTask_VAE.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию\r\nво втором столбце.\r\n\r\nИсходный массив:\r\n -7 34 -2 25 5\r\n-16 -12 30 -3 17\r\n 3 -15 12 5 -5\r\n 17 22 -3 32 -11\r\n 9 28 1 -9 -2";
            // 
            // dataGridViewResult_VAE
            // 
            dataGridViewResult_VAE.AllowUserToAddRows = false;
            dataGridViewResult_VAE.ColumnHeadersHeight = 29;
            dataGridViewResult_VAE.Location = new Point(553, 30);
            dataGridViewResult_VAE.Name = "dataGridViewResult_VAE";
            dataGridViewResult_VAE.ReadOnly = true;
            dataGridViewResult_VAE.RowHeadersWidth = 51;
            dataGridViewResult_VAE.Size = new Size(500, 250);
            dataGridViewResult_VAE.TabIndex = 2;
            // 
            // buttonExecute_VAE
            // 
            buttonExecute_VAE.Location = new Point(350, 400);
            buttonExecute_VAE.Name = "buttonExecute_VAE";
            buttonExecute_VAE.Size = new Size(100, 30);
            buttonExecute_VAE.TabIndex = 3;
            buttonExecute_VAE.Text = "Выполнить";
            buttonExecute_VAE.Click += buttonExecute_Click;
            // 
            // buttonInfo_VAE
            // 
            buttonInfo_VAE.Location = new Point(460, 400);
            buttonInfo_VAE.Name = "buttonInfo_VAE";
            buttonInfo_VAE.Size = new Size(40, 30);
            buttonInfo_VAE.TabIndex = 4;
            buttonInfo_VAE.Text = "?";
            buttonInfo_VAE.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(1088, 450);
            Controls.Add(labelTask);
            Controls.Add(textBoxTask_VAE);
            Controls.Add(dataGridViewResult_VAE);
            Controls.Add(buttonExecute_VAE);
            Controls.Add(buttonInfo_VAE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Власенко А. Е.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_VAE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}