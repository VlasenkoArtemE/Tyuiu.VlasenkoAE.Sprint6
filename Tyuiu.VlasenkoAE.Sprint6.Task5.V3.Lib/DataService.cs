using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VlasenkoAE.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public double[] LoadFromDataFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Файл не найден: {filePath}");

            List<double> numbers = new List<double>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string part in parts)
                {
                    if (double.TryParse(part.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                    {
                        if (num %1 != 0)
                            numbers.Add(Math.Round(num, 3));
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}
