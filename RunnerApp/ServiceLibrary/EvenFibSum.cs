using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class EvenFibSum
    {
        public static long GetSum(long upperBound)
        {
            var result = 0;
            var a = 1;
            var b = 2;
            while (a < upperBound)
            {
                if (a % 2 == 0)
                    result += a;

                var c = a + b;
                a = b;
                b = c;
            }

            return result;
        }
    }
}
