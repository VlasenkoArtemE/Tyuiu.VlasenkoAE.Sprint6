using System.IO;
using Tyuiu.VlasenkoAE.Sprint6.Task7.V13.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            
            string testFile = "test_input.csv";

            string[] testData = {
                "1;2;3;4;5;6;7;8;9;10",
                "-1;-2;-3;-4;-5;-6;-7;-8;-9;-10",
                "11;12;13;14;15;16;17;18;19;20",
                "0;0;0;0;0;0;0;0;0;0",
                "21;22;23;24;25;26;27;28;29;30"
            };

            File.WriteAllLines(testFile, testData);

            int[,] result = ds.GetMatrix(testFile);

            Assert.AreEqual(111, result[0, 5]);
            Assert.AreEqual(-6, result[1, 5]);
            Assert.AreEqual(111, result[2, 5]);
            Assert.AreEqual(0, result[3, 5]);
            Assert.AreEqual(111, result[4, 5]);

            File.Delete(testFile);
        }
    }
}