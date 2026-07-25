using NUnit.Framework;
using System;

namespace ParameterizedTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        // Test Addition and AllClear
        [Test]
        public void TestAddAndClear()
        {
            int actual = calculator.Add(20, 10);

            Assert.That(actual, Is.EqualTo(30));

            calculator.AllClear();

            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }

        // Test Subtraction
        [TestCase(20, 10, 10)]
        [TestCase(50, 20, 30)]
        [TestCase(100, 40, 60)]
        public void TestSubtract(int a, int b, int expected)
        {
            int actual = calculator.Subtract(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Multiplication
        [TestCase(2, 3, 6)]
        [TestCase(5, 4, 20)]
        [TestCase(10, 10, 100)]
        public void TestMultiply(int a, int b, int expected)
        {
            int actual = calculator.Multiply(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Division
        [TestCase(20, 2, 10)]
        [TestCase(100, 10, 10)]
        [TestCase(12, 3, 4)]
        public void TestDivision(int a, int b, int expected)
        {
            int actual = calculator.Divide(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        // Test Division by Zero
        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                calculator.Divide(20, 0);
            });
        }
    }
}