using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.VlasenkoAE.Sprint6.Task5.V3.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        private DataService dataService;
        private double[] allValues = Array.Empty<double>();
        private double[] filteredValues = Array.Empty<double>();

        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\artem\source\repos\Tyuiu.VlasenkoAE.Sprint6\Sprint6Task5\InPutFileTask5V3.txt";
                allValues = ds.LoadFromDataFile(filePath);
                filteredValues = allValues.Where(v => v % 1 != 0).ToArray();

                dataGridViewValues.Rows.Clear();
                dataGridViewValues.Columns.Clear();

                dataGridViewValues.Columns.Add("colAll", "Все значения");
                dataGridViewValues.Columns.Add("colFiltered", "%1 != 0");

                int rowCount = Math.Max(allValues.Length, filteredValues.Length);

                for (int i = 0; i < rowCount; i++)
                {
                    string allVal = (i < allValues.Length) ? allValues[i].ToString("0.###") : "";
                    string filteredVal = (i < filteredValues.Length) ? filteredValues[i].ToString("0.###") : "";
                    dataGridViewValues.Rows.Add(allVal, filteredVal);
                }

                pictureBoxChart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (filteredValues.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int margin = 50;
            int width = pictureBoxChart.Width - 2 * margin;
            int height = pictureBoxChart.Height - 2 * margin;

            Pen axis = new Pen(Color.Black, 2);
            g.DrawLine(axis, margin, margin, margin, margin + height);
            g.DrawLine(axis, margin, margin + height, margin + width, margin + height);

            Font font = new Font("Arial", 10);
            g.DrawString("Значения", font, Brushes.Black, margin + width / 2 - 30, margin + height + 20);
            g.DrawString("%1 != 0", font, Brushes.Black, 10, margin);

            double maxVal = filteredValues.Max();
            if (maxVal == 0) maxVal = 1;

            int barWidth = Math.Min(40, width / Math.Max(1, filteredValues.Length) - 5);

            for (int i = 0; i < filteredValues.Length; i++)
            {
                double val = filteredValues[i];
                int barHeight = (int)((val / maxVal) * (height - 20));

                int x = margin + 10 + i * (barWidth + 10);
                int y = margin + height - barHeight;

                int red = Math.Clamp(100 + i * 15, 0, 255);
                int green = 100;
                int blue = Math.Clamp(150 + i * 5, 0, 255);
                Brush bar = new SolidBrush(Color.FromArgb(red, green, blue));

                g.FillRectangle(bar, x, y, barWidth, barHeight);
                g.DrawRectangle(Pens.DarkBlue, x, y, barWidth, barHeight);

                string label = val.ToString("0.###");
                SizeF size = g.MeasureString(label, font);
                if (y - size.Height - 5 > 0)
                    g.DrawString(label, font, Brushes.Black, x + barWidth / 2 - size.Width / 2, y - size.Height - 5);

                g.DrawString((i + 1).ToString(), font, Brushes.Black, x + barWidth / 2 - 5, margin + height + 5);

                bar.Dispose();
            }

            axis.Dispose();
            font.Dispose();
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 | Таск 5 | Вариант 3\nВыполнил: Власенко А. Е.\n" +
                "Программа загружает данные из файла InPutFileTask5V3.txt\n" +
                "Выводит вещественные числа и строит диаграмму.",
                "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}