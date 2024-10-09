using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ritangle
{
    internal class Problem3
    {
        private List<int> denominations = new List<int>() { 60, 30, 20, 15, 12, 10, 6, 5, 4, 3, 2, 1 };

        public int Compute()
        {
            List<int> coins = new List<int>() { 0 };

            foreach (int denomination in denominations)
            {
                while (true)
                {
                    Console.WriteLine(string.Join(", ", coins));
                    coins.Add(denomination);
                    if (CanSumTo(120, coins))
                    {
                        coins.Remove(denomination);
                        break;
                    }
                }
            }

            return coins.Sum();
        }
            
        public bool CanSumTo(int total, List<int> ints) =>
            Recursion(total, ints, 0);

        public bool Recursion(int total, List<int> ints, int startIndex)
        {
            if (total == 0) return true;
            if (startIndex >= ints.Count) return false;

            if (Recursion(total - ints[startIndex], ints, startIndex + 1)) return true;
            return Recursion(total, ints, startIndex + 1);
        }
    }
}
