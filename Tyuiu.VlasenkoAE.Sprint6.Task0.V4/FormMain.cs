using System;
using System.Windows.Forms;
using Tyuiu.VlasenkoAE.Sprint6.Task0.V4.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 3;
                double res = ds.Calculate(x);
                textBoxRes_VAE.Text = $"Результат: {res}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Таск 0, cпринт 6, вариант 4 выполнил студент группы ИСТНб-25-1 Власенко Артём Евгеньевич",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void textBoxRes_VAE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}