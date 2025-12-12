using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VlasenkoAE.Sprint6.Task7.V13.Lib
{
    public class DataService : ISprint6Task7V13
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(";").Length;

            int Xcol = 5;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(line_i[j]);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = Xcol; c <= Xcol; c++)
                {
                    if (matrix[r, c] % 2 == 0 && matrix[r, c] > 0)
                    {
                        matrix[r, c] = 111;
                    }
                }
            }
            return matrix;
        }
    }
}
