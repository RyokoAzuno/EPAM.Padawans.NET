using NUnit.Framework;
using static PadawansTask2.ArithmeticSequence;

namespace PadawansTask2.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase(2, 3, 5, ExpectedResult = 40)]
        [TestCase(3, 2, 1, ExpectedResult = 3)]
        public int CalculateTests(int number, int add, int count)
            => Calculate(number, add, count);

        [Test]
        public void CalculateTest_CountLessOrEqualsZero_ThrowArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => ArithmeticSequence.Calculate(3, 2, -10));
        }

        [Test]
        public void CalculateTest_SumOutOfRange_ThrowOverflowException()
        {
            Assert.Throws<System.OverflowException>(() => ArithmeticSequence.Calculate(int.MaxValue, 1, 2));
            Assert.Throws<System.OverflowException>(() => ArithmeticSequence.Calculate(int.MinValue, -1, 2));
        }
    }
}
