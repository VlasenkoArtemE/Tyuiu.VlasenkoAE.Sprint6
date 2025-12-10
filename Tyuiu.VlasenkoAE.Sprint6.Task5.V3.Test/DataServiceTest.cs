using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VlasenkoAE.Sprint6.Task5.V3.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_FilterAndRound_Test()
        {
            string testPath = Path.Combine(Path.GetTempPath(), "TestFileTask5V3.txt");

            string testData = "8 11.0 -11.4 9 90.0\n11.44 18 -12.98 14 34 56.28";
            File.WriteAllText(testPath, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testPath);

            double[] expected = new double[]
            {
                -11.4, 11.44, -12.98, 56.28
            };

            CollectionAssert.AreEqual(expected, result);

            File.Delete(testPath);
        }
    }
}