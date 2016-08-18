﻿using ServiceLibrary;
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
            var sumOf1000 = MathProblems.GetSumOfMultiplesOf3And5(1000);
            Console.WriteLine($"Sum of multiples of 3 and 5 for 1,000: {sumOf1000}");

            var sumOf4mil = MathProblems.GetSumOfEvenFib(4000000);
            Console.WriteLine($"Sum of even Fibonnaci of 4,000,000: {sumOf4mil}");

            long number = 600851475143;
            var largestPrime = MathProblems.GetLargestPrimeFactor(number);
            Console.WriteLine($"Largest prime factor of {number.ToString("N0")}: {largestPrime.ToString("N0")}");

            Console.ReadLine();
        }
    }
}
