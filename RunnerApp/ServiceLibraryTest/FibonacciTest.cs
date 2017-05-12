using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibraryTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void GetEvenFibSumBaseTest()
        {
            var sumOf89 = Fibonacci.GetSumOfEvenFib(89);
            Assert.AreEqual(44, sumOf89);
        }
    }
}
