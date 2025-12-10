using Tyuiu.VlasenkoAE.Sprint6.Task3.V13.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[,] matrix = {
                { -7, 34, -2, 25, 5 },
                { -16, -12, 30, -3, 17 },
                { 3, -15, 12, 5, -5 },
                { 17, 22, -3, 32, -11 },
                { 9, 28, 1, -9, -2 }
            };

            int[,] sorted = ds.Calculate(matrix);

            dataGridViewResult_VAE.ColumnCount = 5;
            dataGridViewResult_VAE.RowCount = 5;
            dataGridViewResult_VAE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_VAE.Columns[i].HeaderText = $"{i + 1}";
                for (int j = 0; j < 5; j++)
                    dataGridViewResult_VAE.Rows[i].Cells[j].Value = sorted[i, j];
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-25-1 Власенко Артём Евгеньевич");
        }
    }
}
