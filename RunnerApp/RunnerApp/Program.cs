using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunnerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumOf1000 = ThreeOfFive.GetSumOfMultiplesOf3And5(1000);
            Console.WriteLine($"Sum of multiples of 3 and 5: {sumOf1000}");

            var sumOf4mil = EvenFibSum.GetSum(4000000);
            Console.WriteLine($"Sum of even Fibonnaci: {sumOf4mil}");

            Console.ReadLine();
        }
    }
}
