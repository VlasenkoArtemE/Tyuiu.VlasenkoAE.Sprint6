using System.Drawing.Text;
using Tyuiu.VlasenkoAE.Sprint6.Task1.V8.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        public void buttonRun_Click(object sender, EventArgs e)
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

                textBoxRes_VAE.Text = "";
                textBoxRes_VAE.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_VAE.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes_VAE.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <=len -1; i++)
                {
                    strLine = String.Format("| {0,5:d}    |   {1, 5:f1}  |", startStep, valueArray[i]);
                    textBoxRes_VAE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxRes_VAE.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-25-1 Власенко Артём Евгеньевич");
        }
    }
}
