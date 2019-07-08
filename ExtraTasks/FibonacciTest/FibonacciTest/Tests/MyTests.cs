using NUnit.Framework;
using System.Collections.Generic;

namespace FibonacciTest.Tests
{
    [TestFixture]
    public class MyTests
    {
        [TestCase(20, ExpectedResult = 6765)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(0, ExpectedResult = 0)]
        public int FibonacciRecTests(int number) => FibonacciClass.FibonacciRec(number);

        [TestCase(20, ExpectedResult = 6765)]
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(0, ExpectedResult = 0)]
        public int FibonacciTests(int number) => FibonacciClass.Fibonacci(number);

        [Test]
        public void Fibonacci_Negative_Numbers_ThrowArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => FibonacciClass.FibonacciRec(-1));
            Assert.Throws<System.ArgumentException>(() => FibonacciClass.Fibonacci(-12));
        }

        [Test]
        public void FibonacciListTests()
        {
            List<int> lst1 = new List<int> { 1 };
            List<int> lst2 = new List<int> { 1, 1 };
            List<int> lst3 = new List<int> { 1, 1, 2 };
            List<int> lst4 = new List<int> { 1, 1, 2, 3 };
            List<int> lst7 = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            List<int> lst10 = new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            CollectionAssert.AreEquivalent(lst1, FibonacciClass.FibonacciList(1));
            CollectionAssert.AreEquivalent(lst2, FibonacciClass.FibonacciList(2));
            CollectionAssert.AreEquivalent(lst3, FibonacciClass.FibonacciList(3));
            CollectionAssert.AreEquivalent(lst4, FibonacciClass.FibonacciList(4));
            CollectionAssert.AreEquivalent(lst7, FibonacciClass.FibonacciList(7));
            CollectionAssert.AreEquivalent(lst10, FibonacciClass.FibonacciList(10));
            Assert.Throws<System.ArgumentException>(() => FibonacciClass.FibonacciList(0));
            Assert.Throws<System.ArgumentException>(() => FibonacciClass.FibonacciList(-5));
        }
    }
}
