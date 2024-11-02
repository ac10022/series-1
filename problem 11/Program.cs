using ritangle;
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
            DateHelper dh = new DateHelper();
            List<DateTime> list = new List<DateTime>();

            DateTime dateTime = DateTime.Today;

            while (dateTime < new DateTime(2099, 12, 31))
            {
                if (dh.IsDivisorDate(dateTime))
                {
                    Console.WriteLine(dh.ToDateString(dateTime));
                    list.Add(dateTime);
                }

                dateTime = dateTime.AddDays(1);
            }

            List<Tuple<double, DateTime, DateTime>> timeSpans = new List<Tuple<double, DateTime, DateTime>>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                double span = list[i + 1].Subtract(list[i]).TotalDays;
                timeSpans.Add(new Tuple<double, DateTime, DateTime>(span, list[i], list[i + 1]));
            }

            foreach (var item in timeSpans)
            {
                Console.WriteLine(item.Item1);
            }

            Tuple<double, DateTime, DateTime> max = timeSpans.OrderByDescending(x => x.Item1).FirstOrDefault();

            Console.WriteLine($"Max: between {max.Item2}, {max.Item3} => {max.Item1} days");
        }
    }
}
