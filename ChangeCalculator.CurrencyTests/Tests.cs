using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeCalculator.Calculator;
using System.Collections.Generic;

namespace ChangeCalculator.CurrencyTests
{
    [TestClass]
    public class Tests
    {
        ICurrency currencyValid;
        ICurrency currencyInvalid;
       
        [TestInitialize]
        public void TestInit()
        {
            currencyValid = new Currency()
            {
                Suffix = "p",
                Symbol = "£",
                Denomination = new List<string>() { "50", "20", "10" }
            };

            currencyInvalid = new Currency()
            {
                Suffix = "",
                Symbol = "",
                Denomination = new List<string>() { "50", "ab", "10" }
            };
        }

        [TestMethod]
        public void Currency_IsDenominationValid_Return_True_When_Valid()
        {
            Assert.IsTrue(currencyValid.IsDenominationValid());
        }

        [TestMethod]
        public void IsTrue_When_Currency_Suffix_Is_Valid()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(currencyValid.Suffix));
        }

        [TestMethod]
        public void IsTrue_When_Currency_Symbol_Is_Valid()
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(currencyValid.Symbol));
        }

        [TestMethod]
        public void Currency_IsDenominationValid_Return_False_When_InValid()
        {
            Assert.IsFalse(currencyInvalid.IsDenominationValid());
        }

        [TestMethod]
        public void IsFalse_When_Currency_Suffix_Is_Invalid()
        {
            Assert.IsFalse(!string.IsNullOrWhiteSpace(currencyInvalid.Suffix));
        }

        [TestMethod]
        public void IsFalse_When_Currency_Symbol_Is_Invalid()
        {
            Assert.IsFalse(!string.IsNullOrWhiteSpace(currencyInvalid.Symbol));
        }

    }
}
