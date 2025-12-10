using System.IO;
using Tyuiu.VlasenkoAE.Sprint6.Task4.V3.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);
            double[] expected = new double[11];

            for (int i = 0; i < 11; i++)
            {
                double x = -5 + i;
                double znam = Math.Sin(x) - 3 + x;
                expected[i] = znam == 0
                    ? 0
                    : Math.Round(((3 * x - 1.5) / znam + 2), 2);
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
