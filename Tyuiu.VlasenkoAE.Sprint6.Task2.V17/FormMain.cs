using Tyuiu.VlasenkoAE.Sprint6.Task2.V17.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task2.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_VAE.Text);
                int stopStep = Convert.ToInt32(textBoxStop_VAE.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_VAE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_VAE.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_VAE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_VAE.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-25-1 Власенко Артём Евгеньевич");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRunEnter_VAE(object sender, EventArgs e)
        {
            buttonRun_VAE.BackColor = Color.Red;
        }

        private void buttonRunDown_VAE(object sender, MouseEventArgs e)
        {
            buttonRun_VAE.BackColor = Color.Blue;
        }

        private void buttonRunLeave_VAE(object sender, EventArgs e)
        {
            buttonRun_VAE.BackColor = Color.Green;
        }
    }

}
