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
    public class SumOfMultiplesTest
    {
        [TestMethod]
        public void GetSumOfMultiplesOf3And5Test()
        {
            var sumOf10 = SumOfMultiples.GetSumOfMultiplesOf3And5(10);
            Assert.AreEqual(23, sumOf10);
        }
    }
}
