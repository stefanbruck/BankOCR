using System.Collections.Generic;
using BankOCR;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScanToBankAccountTest
{
    [TestClass]
    public class ScanToBankAccountTests
    {
        [TestInitialize]
        public void Setup()
        {
            var x = 10;
        }

        [TestMethod]
        public void Convert_ComplexeNumberWith9DifferentDigits_ParseCorrect()
        {
            var number = new List<string>{"    _  _     _  _  _  _  _ " ,
                                          "  | _| _||_||_ |_   ||_||_|" ,
                                          "  ||_  _|  | _||_|  ||_| _|" ,
                                          "                           "};

            var target = new ScanToBankAccount();

            var result = target.Convert(number)

            Assert.AreEqual(result, 123456789);
        }
    }
}
