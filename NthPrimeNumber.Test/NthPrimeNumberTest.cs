using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NthPrimeNumber;

namespace NthPrimeNumber.Test
{
    [TestClass]
    public class NthPrimeNumberTest
    {
        public PrimeNumber pn { get; set; }

        [TestInitialize]
        public void SUT()
        {
            pn = new PrimeNumber();
        }
        [TestMethod]
        public void InputOne_ReturnTwo()
        {
            int result = pn.GetNthPrimeNumber(1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void InputTwo_ReturnThree()
        {
            int result = pn.GetNthPrimeNumber(2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void InputThree_ReturnFive()
        {
            int result = pn.GetNthPrimeNumber(3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void InputFour_ReturnSeven()
        {
            int result = pn.GetNthPrimeNumber(4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void IsPrime_Input2_OutputTrue()
        {
            bool result = pn.IsPrime(2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrime_Input3_OutputTrue()
        {
            bool result = pn.IsPrime(3);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPrime_Input10_OutputFalse()
        {
            bool result = pn.IsPrime(10);
            Assert.IsFalse(result);
        }
    }
}
