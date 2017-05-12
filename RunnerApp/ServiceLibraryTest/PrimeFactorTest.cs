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
    public class PrimeFactorTest
    {
        [TestMethod]
        public void GetLargestPrimeFactorTest()
        {
            var largest = PrimeFactor.GetLargestPrimeFactor(13195);
            Assert.AreEqual(29, largest);
        }
    }
}
