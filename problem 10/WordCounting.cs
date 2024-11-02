using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ritangle
{
    internal class WordCounting
    {
        private List<string> wordNums = new List<string>() { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine", "thirty", "thirty one", "thirty two", "thirty three", "thirty four", "thirty five", "thirty six", "thirty seven", "thirty eight", "thirty nine", "forty", "forty one", "forty two", "forty three", "forty four", "forty five", "forty six", "forty seven", "forty eight", "forty nine", "fifty", "fifty one", "fifty two", "fifty three", "fifty four", "fifty five", "fifty six", "fifty seven", "fifty eight", "fifty nine", "sixty", "sixty one", "sixty two", "sixty three", "sixty four", "sixty five", "sixty six", "sixty seven", "sixty eight", "sixty nine", "seventy", "seventy one", "seventy two", "seventy three", "seventy four", "seventy five", "seventy six", "seventy seven", "seventy eight", "seventy nine", "eighty", "eighty one", "eighty two", "eighty three", "eighty four", "eighty five", "eighty six", "eighty seven", "eighty eight", "eighty nine", "ninety", "ninety one", "ninety two", "ninety three", "ninety four", "ninety five", "ninety six", "ninety seven", "ninety eight", "ninety nine", "one hundred" };

        private string GetNumWord(int num) => wordNums[num];

        private int GetNumWordWordCount(int num) => GetNumWord(num).Contains(" ") ? 2 : 1;

        private int GetNumWordVowels(int num) => new Regex(@"[aeiou]", RegexOptions.IgnoreCase).Matches(GetNumWord(num)).Count;

        public List<Tuple<int, int>> Iterate()
        {
            List<Tuple<int, int>> res = new List<Tuple<int, int>>();

            for (int i = 18; i <= 100; i++)
            {
                for (int j = 31; j <= 100; j++)
                {
                    if (17 + GetNumWordWordCount(i) + GetNumWordWordCount(j) == i && 31 + GetNumWordVowels(i) + GetNumWordVowels(j) == j) res.Add(new Tuple<int, int>(i, j));
                }
            }

            return res;
        }

        public int Compute()
        {
            List<Tuple<int, int>> res = Iterate();
            return res.Select(x => x.Item1 * x.Item2).Sum();
        }
    }
}
