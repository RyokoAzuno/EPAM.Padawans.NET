using NUnit.Framework;
using static PadawansTask3.IntegerExtensions;

namespace PadawansTask3.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase(30, 12, ExpectedResult = 6)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(8, 9, ExpectedResult = 1)]
        [TestCase(50, 250, ExpectedResult = 50)]
        [TestCase(10927782, -6902514, ExpectedResult = 846)]
        [TestCase(-10234567, -234568989, ExpectedResult = 97)]
        [TestCase(0, -301, ExpectedResult = 301)]
        [TestCase(-1590771464, 0, ExpectedResult = 1590771464)]
        [TestCase(10927782, 0, ExpectedResult = 10927782)]
        public int GcdTests(int a, int b) => Gcd(a, b);

        [Test]
        public void GcdTest_WithTwoZeroNumbers_ThrowArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => GcdTests(0, 0));
        }
    }
}
