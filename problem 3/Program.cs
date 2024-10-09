using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Denominations denominations = new Denominations();
            Console.WriteLine(denominations.Compute());
        }
    }
}
