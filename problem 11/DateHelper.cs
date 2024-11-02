using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ritangle
{
    internal class DateHelper
    {
        public bool IsDivisorDate(DateTime dt)
        {
            return IsDivisor(dt.Month, dt.Day) && IsDivisor(dt.Year - 2000, dt.Month) && dt.Day > 1 && dt.Month > dt.Day && (dt.Year - 2000 > dt.Month);
        }

        public bool IsDivisor(int dividend, int divisor) => (dividend / (double)divisor) == Math.Floor(dividend / (double)divisor);

        public string ToDateString(DateTime dt) => $"{dt.Day}{dt.Month.ToString().PadLeft(2, '0')}{dt.Year}";
    }
}
