using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojo_01_FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void EinsIstNichtDurch3Teilbar()
        {
            bool value = FizzBuzz.IstDurch3Teilbar(1);
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void DreiIstDurch3Teilbar()
        {
            bool value = FizzBuzz.IstDurch3Teilbar(3);
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void EinsIstNichtDurch5Teilbar()
        {
            bool value = FizzBuzz.IstDurch5Teilbar(1);
            Assert.IsFalse(value);
        }

        [TestMethod]
        public void FuenfIstDurch5Teilbar()
        {
            bool value = FizzBuzz.IstDurch5Teilbar(5);
            Assert.IsTrue(value);
        }

        [TestMethod]
        public void WennNurDurch3TeilbarDannFizz()
        {
            string result = FizzBuzz.AusgabeTextGenerieren(true, false, 3);
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void WennNurDurch5TeilbarDannBuzz()
        {
            string result = FizzBuzz.AusgabeTextGenerieren(false, true, 25);
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void WennDurch3Und5TeilbarDannFizzBuzz()
        {
            string result = FizzBuzz.AusgabeTextGenerieren(true, true, 75);
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void WennWederDurch3Oder5TeilbarDannWert()
        {
            string result = FizzBuzz.AusgabeTextGenerieren(false, false, 7);
            Assert.AreEqual("7", result);
        }
    }
}
