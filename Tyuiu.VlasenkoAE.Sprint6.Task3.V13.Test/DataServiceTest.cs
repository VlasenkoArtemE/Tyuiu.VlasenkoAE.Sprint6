using Tyuiu.VlasenkoAE.Sprint6.Task3.V13.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { -7, 34, -2, 25, 5 },
                { -16, -12, 30, -3, 17 },
                { 3, -15, 12, 5, -5 },
                { 17, 22, -3, 32, -11 },
                { 9, 28, 1, -9, -2 }
            };

            int[,] sorted = ds.Calculate(matrix);

            int[] expected = { -15, -12, 22, 28, 34 };
            for (int i = 0; i < 5; i++)
                Assert.AreEqual(expected[i], sorted[i, 1]);
        }
    }
}
