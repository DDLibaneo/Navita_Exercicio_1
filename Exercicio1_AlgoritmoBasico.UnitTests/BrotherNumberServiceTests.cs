using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicio1_AlgoritmoBasico.UnitTests
{
    [TestClass]
    public class BrotherNumberServiceTests
    {
        [TestMethod]
        public void LargestNumberOnNFamily_WhenCalledPassingValidParameter_ReturnLargestNumberOnNFamily()
        {
            Assert.AreEqual(321, BrotherNumberService.LargestNumberOnNFamily(213));
            Assert.AreEqual(553, BrotherNumberService.LargestNumberOnNFamily(553));
        }

        [TestMethod]
        public void LargestNumberOnNFamily_WhenCalledPassingANumberHigherThanAHundredMillion_ReturnMinusOne()
        {
            Assert.AreEqual(-1, BrotherNumberService.LargestNumberOnNFamily(100000001));
        }

        [TestMethod]
        public void LargestNumberOnNFamily_WhenCalledPassingAHundredMillion_ReturnAHundredMillion()
        {
            Assert.AreEqual(100000000, BrotherNumberService.LargestNumberOnNFamily(100000000));
        }
    }
}
