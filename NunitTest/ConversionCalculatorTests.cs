using NUnit.Framework;
using System;

namespace ConversionCalculatorBLTests
{
    public class ConverstionCalculationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConvertFourToBinary()
        {
            // arrange
            String inputNumber = "4";

            // act
            String result = ConversionCalculatorBL.ConvertNumber.toBinary(inputNumber);

            // assert
            StringAssert.AreEqualIgnoringCase("100", result);
        }

        [Test]
        public void ConvertOneHundredToDecimal()
        {
            // arrange
            String inputNumber = "100";

            // act
            String result = ConversionCalculatorBL.ConvertNumber.toDecimal(inputNumber);

            // assert
            StringAssert.AreEqualIgnoringCase("4", result);
        }

        [Test]
        public void ConvertInvalidBinaryToDecimal()
        {
            // arrange
            String inputNumber = "104";

            // act
            String result = ConversionCalculatorBL.ConvertNumber.toDecimal(inputNumber);

            // assert
            StringAssert.AreEqualIgnoringCase("Invalid Binary Number", result);
        }

        [Test]
        public void ConvertInvalidNumberToDecimal()
        {
            // arrange
            String inputNumber = "100A";

            // act
            String result = ConversionCalculatorBL.ConvertNumber.toDecimal(inputNumber);

            // assert
            StringAssert.AreEqualIgnoringCase("Not a valid number", result);
        }

        [Test]
        public void ConvertInvalidNumberToBinary()
        {
            // arrange
            String inputNumber = "100A";

            // act
            String result = ConversionCalculatorBL.ConvertNumber.toBinary(inputNumber);

            // assert
            StringAssert.AreEqualIgnoringCase("Not a valid number", result);
        }
    }
}