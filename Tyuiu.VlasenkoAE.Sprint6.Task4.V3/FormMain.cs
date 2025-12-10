using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Tyuiu.VlasenkoAE.Sprint6.Task4.V3.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        double[] functionValues = Array.Empty<double>();
        int startX = -5;
        int endX = 5;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            functionValues = ds.GetMassFunction(startX, endX);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*********************************");
            sb.AppendLine("*       x       *      f(x)     *");
            sb.AppendLine("*********************************");

            for (int i = 0; i < functionValues.Length; i++)
                sb.AppendLine($"*    {startX + i,5:F0}     *    {functionValues[i],7:F2}    *");

            sb.AppendLine("*********************************");
            textBoxResult.Text = sb.ToString();

            pictureBoxChart.Refresh();
        }

        private void pictureBoxChart_Paint(object sender, PaintEventArgs e)
        {
            if (functionValues.Length == 0) return;

            Graphics g = e.Graphics;
            g.Clear(Color.White);

            int width = pictureBoxChart.Width - 40;
            int height = pictureBoxChart.Height - 40;

            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, 20, height / 2, width + 20, height / 2);
            g.DrawLine(axisPen, 20, 20, 20, height + 20);

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double v in functionValues)
            {
                if (v < min) min = v;
                if (v > max) max = v;
            }

            if (Math.Abs(max - min) < 0.0001)
            {
                max = min + 2;
                min = min - 2;
            }

            double dx = width / (double)(functionValues.Length - 1);
            double scaleY = height / (max - min);

            Pen graphPen = new Pen(Color.Blue, 2);
            for (int i = 0; i < functionValues.Length - 1; i++)
            {
                float x1 = (float)(20 + i * dx);
                float x2 = (float)(20 + (i + 1) * dx);
                float y1 = (float)(20 + height - (functionValues[i] - min) * scaleY);
                float y2 = (float)(20 + height - (functionValues[i + 1] - min) * scaleY);
                g.DrawLine(graphPen, x1, y1, x2, y2);
            }

            Font labelFont = new Font("Arial", 8);
            for (int i = 0; i < functionValues.Length; i += 2)
            {
                float x = (float)(20 + i * dx);
                float y = (float)(20 + height - (functionValues[i] - min) * scaleY);
                g.FillEllipse(Brushes.Red, x - 3, y - 3, 6, 6);
                g.DrawString($"({startX + i}, {functionValues[i]:F2})", labelFont, Brushes.DarkBlue, x + 5, y - 15);
            }

            axisPen.Dispose();
            graphPen.Dispose();
            labelFont.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string textPath = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V3.txt");
            File.WriteAllText(textPath, textBoxResult.Text, Encoding.UTF8);

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask4V3.png");
            Bitmap bmp = new Bitmap(pictureBoxChart.Width, pictureBoxChart.Height);
            pictureBoxChart.DrawToBitmap(bmp, pictureBoxChart.ClientRectangle);
            bmp.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();

            MessageBox.Show($"Файлы сохранены:\n\nТекст: {textPath}\nГрафик: {imagePath}",
                "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-25-1 Власенко Артём Евгеньевич");
        }
    }
}
