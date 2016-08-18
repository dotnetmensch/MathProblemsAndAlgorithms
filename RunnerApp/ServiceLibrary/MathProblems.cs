using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class MathProblems
    {
        public static long GetSumOfEvenFib(long upperBound)
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

        public static long GetLargestPrimeFactor(long number)
        {
            long factor = 2;
            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    number /= factor;
                }
                else
                {
                    factor++;
                }
            }

            return number;
        }

        public static long GetSumOfMultiplesOf3And5(long upperbound)
        {
            long result = 0;
            for (long i = 0; i < upperbound; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        public static int LargestPalindromicProductOfTwo3DigitNumbers()
        {
            int result = 0;
            int i = 999;
            do
            {
                for (int j = 999; j <= 100; j--)
                {
                    var test = j * i;
                    if (test.IsPalindromic() && test > result)
                    {
                        result = test;
                        break;
                    }
                }
                i--;

            }
            while (i <= 100);


            return result;
        }


        private static bool IsPalindromic(this int number)
        {
            return number.ToString() == number.ToString().Reverse().ToString();
        }
    }
}
