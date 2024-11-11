using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritangle
{
    internal class TriangleNumbers
    {
        public void Compute()
        {
            Dictionary<int, char> triangleNumbers = new Dictionary<int, char>();
            for (int i = 1; i < 447; i++)
            {
                triangleNumbers.Add((int)(0.5 * i * (i + 1)), "TRIANGLE"[(i-1)%8]);
            }

            Dictionary<int, char> nineties = new Dictionary<int, char>();
            for (int j = 1; j < 1112; j++)
            {
                nineties.Add(90 * j, "RITANGLE"[(j - 1) % 8]);
            }

            List<int> pairs = triangleNumbers.Where(x => nineties.Contains(new KeyValuePair<int, char>(x.Key, x.Value))).Select(x => x.Key).ToList();

            foreach (int item in pairs)
            {
                Console.WriteLine($"{item} => T: {triangleNumbers[item]}, N: {nineties[item]}");
            }
        }
    }
}
