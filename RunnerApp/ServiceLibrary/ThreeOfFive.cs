using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class ThreeOfFive
    {
        public static int GetSumOfMultiplesOf3And5(int upperBound)
        {
            var result = 0;
            for (int i = 0; i < upperBound; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }


    }
}
