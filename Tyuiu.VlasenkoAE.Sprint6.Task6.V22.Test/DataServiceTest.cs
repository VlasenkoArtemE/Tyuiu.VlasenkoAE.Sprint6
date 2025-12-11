using System.IO;
using Tyuiu.VlasenkoAE.Sprint6.Task6.V22.Lib;

namespace Tyuiu.VlasenkoAE.Sprint6.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();

            string[] lines =
            {
            "MLgyapd btwMCZUcB dwCKLDzrngpZmJ",
            "kEPQzl NkEjxsqwKh PADUsjhlu JmSRt",
            "IOuDWll JmjQKHd gRwqYNbPcwgQilXS",
            "TMRyztkPxzEVkcarVMlQ HjOGYcyzHD",
            "unwTmf EUWCvEgL CmqxgaKlPLMCQBJC"
            };

            File.WriteAllLines(tempFile, lines);

            try
            {
                string res = ds.CollectTextFromFile(tempFile);
                string wait = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";

                Assert.AreEqual(wait, res);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }
    }
}
