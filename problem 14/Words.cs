using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritangle
{
    internal class Words
    {
        private List<string> words;

        public Words()
        {
            using (FileStream fs = new FileStream(@"C:\Users\lucam\Downloads\numbers.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string input = sr.ReadToEnd();
                    words = input.Split(',').ToList();
                }
            }
        }

        public int Compute()
        {
            string[] orderedWordsArray = new string[words.Count];
            words.CopyTo(orderedWordsArray);
            Array.Sort(orderedWordsArray);
            List<string> orderedWords = new List<string>(orderedWordsArray);

            Console.WriteLine(orderedWords.IndexOf("eight"));
            Console.WriteLine(orderedWords.IndexOf("nine"));

            return orderedWords.Where(x => orderedWords.IndexOf(x) > orderedWords.IndexOf("eight") && orderedWords.IndexOf(x) < orderedWords.IndexOf("nine")).Select(x => words.IndexOf(x) + 1).Sum();
        }
    }
}
