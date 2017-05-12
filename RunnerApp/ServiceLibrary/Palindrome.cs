using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class Palindrome
    {
        public static int LargestPalindromicOfTwo(int digits)
        {
            string startString = string.Empty;
            var endString = string.Empty;
            for (int k = 0; k < digits; k++)
            {
                startString += "9";
                if (k == 0)
                    endString += "1";
                else
                    endString += "0";
            }
            var start1 = int.Parse(startString);
            var end = int.Parse(endString);

            var result = 0;
            var palindromes = new List<int>();

            for (int i = start1; i >= end; i--)
            {
                for (int j = start1; j >= end; j--)
                {
                    result = i * j;
                    if (result.IsPalindromic())
                        palindromes.Add(result);
                }
            }

            result = palindromes.Max();
            return result;
        }


        private static bool IsPalindromic(this int number)
        {
            return number.ToString() == number.ToString().Reverse().ToString();
        }
    }
}
