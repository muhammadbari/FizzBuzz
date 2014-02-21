using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void GetOutputStringForStep1()
        {
            IFizzBuzz fb = new FizzBuzz1();
            string expected = "1 2 fizz 4 buzz fizz";
            int start = 1;
            int end = 6;
            string actual = fb.GetOutputString(start, end);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringForStep2()
        {
            IFizzBuzz fb = new FizzBuzz2();
            string expected = "1 2 lucky 4 buzz fizz";
            int start = 1;
            int end = 6;
            string actual = fb.GetOutputString(start, end);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetOutputStringForStep3()
        {
            IFizzBuzz fb = new FizzBuzz3();
            string expected = "1 2 lucky 4 buzz fizz\nfizz: 1\nbuzz: 1\nfizzbuzz: 0\nlucky: 1\ninteger: 3";
            int start = 1;
            int end = 6;
            string actual = fb.GetOutputString(start, end);
            Assert.AreEqual(expected, actual);
        }
    }
}
