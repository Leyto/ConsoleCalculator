using ConsoleCalculator.Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PolishCalculatorUnitTest
{
    [TestClass]
    public class PolishCalculatorTests
    {
        [TestMethod]
        public void MultiplicationTest()
        {
            var multiplicationCalculator = new Calculator();
            string input;
            decimal expected;
            decimal actual;

            // Базовая проверка.
            input = "* 10 5";
            expected = 5 * 10;
            actual = multiplicationCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности умножения отрицательных значений: (-3) * (-5) = 15
            input = "* -3 -5";
            expected = (-3) * (-5);
            actual = multiplicationCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности умножения с одним отрицательным значением: (-3) * 5 = -15
            input = "* -3 5";
            expected = (-3) * 5;
            actual = multiplicationCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности умножения отрицательных значений: 3 * (-5) = 15
            input = "* 3 -5";
            expected = 3 * (-5);
            actual = multiplicationCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности умножения на ноль: 3 * 0 = 0
            input = "* 3 0";
            expected = 3 * 0;
            actual = multiplicationCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка ввода некорректных значений
            input = "* 3 a";
            string expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            string actualMessage = string.Empty;
            try
            {
                actual = multiplicationCalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void AdditionalTest()
        {
            var additionalCalculator = new Calculator();
            string input;
            decimal expected;
            decimal actual;

            // Базовая проверка.
            input = "+ 10 5";
            expected = 5 + 10;
            actual = additionalCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения отрицательных значений: (-3) + (-5) = -8
            input = "+ -3 -5";
            expected = (-3) + (-5);
            actual = additionalCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения с одним отрицательным значением: (-3) + 5 = 2
            input = "+ -3 5";
            expected = (-3) + 5;
            actual = additionalCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения с нулём: (-3) + 0 = -3
            input = "+ -3 0";
            expected = (-3) + 0;
            actual = additionalCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка ввода некорректных значений
            input = "+ a 3";
            string expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            string actualMessage = string.Empty;
            try
            {
                actual = additionalCalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void DivisionTest()
        {
            var substractionCalculator = new Calculator();
            string input;
            decimal expected;
            decimal actual;

            // Базовая проверка.
            input = "/ 10 5";
            expected = 10 / 5;
            actual = substractionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения отрицательных значений: (-3) / (-5) = 0.6
            input = "/ -3 -5";
            expected = (decimal)(-3) / (-5);
            actual = substractionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения с одним отрицательным значением: (-3) / 5 = -0.6
            input = "/ -3 5";
            expected = (decimal) -3 / 5;
            actual = substractionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка ошибки при делении на ноль
            input = "/ -3 0";
            string expectedMessage = "Arithmetic error: Division by zero";
            string actualMessage = string.Empty;
            try
            {
                actual = substractionCalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Arithmetic error: Division by zero";
            }
            Assert.AreEqual(expectedMessage, actualMessage);

            // Проверка ввода некорректных значений
            input = "/ -a 3";
            expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            actualMessage = string.Empty;
            try
            {
                actual = substractionCalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void SubstractionTest()
        {
            var divisionCalculator = new Calculator();
            string input;
            decimal expected;
            decimal actual;

            // Базовая проверка.
            input = "- 10 5";
            expected = 10 - 5;
            actual = divisionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения отрицательных значений: (-3) - (-5) = 2
            input = "- -3 -5";
            expected = (-3) - (-5);
            actual = divisionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения с одним отрицательным значением: (-3) - 5 = -8
            input = "- -3 5";
            expected = (-3) - 5;
            actual = divisionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка корректности сложения с нулём: (-3) - 0 = -3
            input = "- -3 0";
            expected = (-3) - 0;
            actual = divisionCalculator.ProcessUserInput(input);
            Assert.AreEqual(expected, actual);

            // Проверка ввода некорректных значений
            input = "- -a 3";
            string expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            string actualMessage = string.Empty;
            try
            {
                actual = divisionCalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        /// <summary>
        /// Проверка некорректных вводимых значений
        /// </summary>
        [TestMethod]
        public void InputTest()
        {
            var сalculator = new Calculator();
            string input, expectedMessage, actualMessage;
            decimal actual;

            //
            input = "-1 3";
            expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            actualMessage = string.Empty;
            try
            {
                actual = сalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);

            //
            input = "a -1 3";
            expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            actualMessage = string.Empty;
            try
            {
                actual = сalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);

            //
            input = "*- -1 3";
            expectedMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            actualMessage = string.Empty;
            try
            {
                actual = сalculator.ProcessUserInput(input);
            }
            catch (InvalidOperationException)
            {
                actualMessage = "Invalid input, I don't know what \"" + input + "\" means.";
            }
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
