using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VlasenkoAE.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);
                StringBuilder result = new StringBuilder();

                foreach (string line in lines)
                {
                    string[] words = line.Split(" ");

                    foreach (string word in words)
                    {
                        if (line.IndexOf(word) == 0)
                        {
                            if (resStr == "")
                            {
                                resStr = resStr + word;
                            }
                            else 
                            {
                                resStr = resStr + " " + word;
                            }
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
