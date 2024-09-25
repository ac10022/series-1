using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace wrytangle
{
    internal class Permutations<T>
    {
        public IEnumerable<T[]> GetPermutations(T[] values, int fromInd = 0)
        {
            if (fromInd + 1 == values.Length)
                yield return values;
            else
            {
                foreach (var v in GetPermutations(values, fromInd + 1))
                    yield return v;

                for (var i = fromInd + 1; i < values.Length; i++)
                {
                    SwapValues(values, fromInd, i);
                    foreach (var v in GetPermutations(values, fromInd + 1))
                        yield return v;
                    SwapValues(values, fromInd, i);
                }
            }
        }

        private void SwapValues(T[] values, int pos1, int pos2)
        {
            if (pos1 != pos2)
            {
                T tmp = values[pos1];
                values[pos1] = values[pos2];
                values[pos2] = tmp;
            }
        }
    }

    internal class PermutationsHelper
    {
        // assume 2|len
        public bool IntComparisonPredicate(int[] values)
        {
            for (int i = 0; i < (values.Length / 2) - 1; i++)
            {
                if (values[2 * i] > values[2 * (i + 1)]) return false;
            }
            return true;
        }

        public int FlattenAndSum(int[] values)
        {
            int total = 0;
            for (int i = 0; i < (values.Length / 2); i++)
            {
                total += int.Parse($"{values[2 * i]}{values[2 * i + 1]}");
            }
            return total;
        }
    }
}
