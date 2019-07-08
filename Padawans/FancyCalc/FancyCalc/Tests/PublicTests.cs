using System;
using NUnit.Framework;

namespace FancyCalc
{
    [TestFixture]
    public class FancyCalculatorTests
    {

        [Test]
        public void AddTest()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected = 4;
            double actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractTest()
        {
            var calc = new FancyCalcEnguine();
            double expected = 0;
            double actual = calc.Subtract(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, ExpectedResult = 9)]
        [TestCase(1, 0, ExpectedResult = 0)]
        public double MultiplyTest(int a, int b)
        {
            var calc = new FancyCalcEnguine();
            return calc.Multiply(a, b);
        }

        [TestCase("2,5 + 10", ExpectedResult = 12.5)]
        [TestCase("3+5", ExpectedResult = 8)]
        [TestCase("   0,23     +  5  ", ExpectedResult = 5.23)]
        [TestCase("8,4 + 3,2   ", ExpectedResult = 11.6)]
        public double CulculateAddTest(string expression)
        {
            var calc = new FancyCalcEnguine();
            return calc.Culculate(expression);
        }

        [TestCase("2,5 - 10", ExpectedResult = -7.5)]
        [TestCase("3-5", ExpectedResult = -2)]
        [TestCase("   0     -  5  ", ExpectedResult = -5)]
        [TestCase("8,4 - 3   ", ExpectedResult = 5.4)]
        public double CulculateSubTest(string expression)
        {
            var calc = new FancyCalcEnguine();
            return calc.Culculate(expression);
        }

        [TestCase("2,5 * 10", ExpectedResult = 25)]
        [TestCase("3*5", ExpectedResult = 15)]
        [TestCase("   0     *  5  ", ExpectedResult = 0)]
        [TestCase("8,4 * 3   ", ExpectedResult = 25.2)]
        public double CulculateMulTest(string expression)
        {
            var calc = new FancyCalcEnguine();
            return calc.Culculate(expression);
        }

        [TestCase("2,5 / 10", ExpectedResult = 0.25)]
        [TestCase("3/5", ExpectedResult = 0.6)]
        [TestCase("8,4 / 3   ", ExpectedResult = 2.8)]
        public double CulculateDivTest(string expression)
        {
            var calc = new FancyCalcEnguine();
            return calc.Culculate(expression);
        }

        [Test]       
        public void CulculateDivByZeroTest()
        {
            var calc = new FancyCalcEnguine();
            string expression = "   0     /  5  ";
            Assert.Throws<DivideByZeroException>(() => calc.Culculate(expression));
        }

        [Test]
        public void CulculateArgumentNullTest()
        {
            var calc = new FancyCalcEnguine();
            string expression1 = null;
            string expression2 = "";
            Assert.Throws<ArgumentNullException>(() => calc.Culculate(expression1));
            Assert.Throws<ArgumentNullException>(() => calc.Culculate(expression2));
        }
    }
}
