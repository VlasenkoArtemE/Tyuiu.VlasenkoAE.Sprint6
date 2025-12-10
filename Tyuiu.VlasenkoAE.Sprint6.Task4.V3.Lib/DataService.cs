using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VlasenkoAE.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] values = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double znam = Math.Sin(x) - 3 + x; 

                if (znam == 0)
                    values[i] = 0;
                else
                    values[i] = Math.Round(((3 * x - 1.5) / znam + 2), 2);
            }
            return values;
        }
    }
}
