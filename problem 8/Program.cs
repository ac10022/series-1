using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Permutations<char> p = new Permutations<char>();
            List<char[]> res = p.GetPermutations(new char[] { 'R', 'I', 'T', 'A', 'N', 'G', 'L', 'E' })
                               .Select(v => (char[])v.Clone())
                               .Where(v => p.VowelPredicate(new string(v)) >= 1)
                               .ToList();

            foreach (char[] item in res)
            {
                Console.WriteLine(new string(item));
            }
            Console.WriteLine(res.Count);

        }
    }
}
