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
    public class PalindromeTest
    {
        [TestMethod]
        public void LargestPalindromeTest()
        {
            var largest = Palindrome.LargestPalindromicOfTwo(2);
            Assert.AreEqual(9009, largest);
        }
    }
}
