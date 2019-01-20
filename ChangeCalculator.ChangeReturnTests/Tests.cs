using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChangeCalculator.Calculator;
using System.Collections.Generic;
using System.Linq;

namespace ChangeCalculator.ChangeReturnTests
{
    [TestClass]
    public class Tests
    {
        ICurrency currencyValid;       
        ChangeReturn changeReturnValid;        

        [TestInitialize]
        public void TestInit()
        {
            currencyValid = new Currency()
            {
                Suffix = "p",
                Symbol = "£",
                Denomination = new List<string>() { "50", "20", "10" }
            };
            changeReturnValid = new ChangeReturn(currencyValid);
            changeReturnValid.ChangeAmount = 30m;
        }

        [TestMethod]
        public void IsTrue_When_ChangeReturn_GetRequiredDenomination_List_Has_Value()
        {
            var denomination = changeReturnValid.GetRequiredDenomination();
            Assert.IsTrue(denomination.Count > 0);
        }
        
        [TestMethod]
        public void IsTrue_When_ChangeReturn_Calculate_Is_Valid()
        {
            var result = changeReturnValid.Calculate();
            Assert.IsTrue(result.Count > 0);
        }
    }
}
