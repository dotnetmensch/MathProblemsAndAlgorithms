using System;
using System.Text;
using System.Collections.Generic;
using ServiceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceLibraryTest
{
    /// <summary>
    /// Summary description for ThreeOfFiveTest
    /// </summary>
    [TestClass]
    public class ServiceLibraryTest
    {
        [TestMethod]
        public void GetSumOfMultiplesOf3And5Test()
        {
            var sumOf10 = ThreeOfFive.GetSumOfMultiplesOf3And5(10);
            Assert.AreEqual(23, sumOf10);
        }

        [TestMethod]
        public void GetEvenFibSum()
        {
            var sumOf89 = EvenFibSum.GetSum(89);
            Assert.AreEqual(44, sumOf89);
        }
    }
}
