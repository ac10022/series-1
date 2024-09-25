using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace wrytangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Permutations<int> p = new Permutations<int>();
            PermutationsHelper ph = new PermutationsHelper();

            List<int[]> res = p.GetPermutations(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })
                               .Select(v => (int[])v.Clone())
                               // predicate
                               .Where(v => ph.IntComparisonPredicate(v))
                               .ToList();

            int combinedTotal = 0;

            foreach (var item in res)
            {
                Console.WriteLine(string.Join(", ", item));
                combinedTotal += ph.FlattenAndSum(item);
            }

            Console.WriteLine($"Combined total: {combinedTotal}");
        }
    }
}
