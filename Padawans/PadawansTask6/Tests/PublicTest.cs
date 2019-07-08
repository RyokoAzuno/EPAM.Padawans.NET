using NUnit.Framework;

namespace PadawansTask6.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase(22222222, ExpectedResult = null)]
        [TestCase(2000000000, ExpectedResult = null)]
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(9, ExpectedResult = null)]
        [TestCase(777, ExpectedResult = null)]
        [TestCase(int.MaxValue, ExpectedResult = null)]
        [TestCase(int.MaxValue - 1, ExpectedResult = null)]
        [TestCase(int.MaxValue - 315, ExpectedResult = null)]
        public int? NextBiggerThanTests(int number) => NumberFinder.NextBiggerThan(number);

        //[Test]
        //public void My_NextBiggerThanTests_OverflowException()
        //{
        //    Assert.Throws<System.OverflowException>(() => NumberFinder.NextBiggerThan(int.MaxValue));
        //}

        [Test]
        public void My_NextBiggerThanTests_ArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => NumberFinder.NextBiggerThan(-5));
            //Assert.Throws<System.ArgumentException>(() => NumberFinder.NextBiggerThan(311111111111));
        }
    }
}
