using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using robertdonoghue_s00190029;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IncreasePriceCheck()
        {
            // arrange
            Phone p1 = new Phone() { Price = 100 };
            double expectedAnswer = 150;

            //act
            p1.IncreasePrice(50);
            double output = p1.Price;

            //assert
            Assert.AreEqual(output, expectedAnswer);


        }
    }
}
