using NUnit.Framework;

namespace PadawansTask1.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void GetYearsTest_With_Result_15()
        {
            Assert.AreEqual(Population.GetYears(1500, 5, 100, 5000), 15);
        }

        [Test]
        public void GetYearsTest_With_Result_27()
        {
            Assert.AreEqual(Population.GetYears(100, 2.5, 80, 3200), 27);
        }

        [Test]
        public void GetYearsTest_CurrentPopulation_LessOrEqualsZero_ThrowArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => Population.GetYears(0, 0.25d, 1000, 0));
        }

        [Test]
        public void GetYearsTest_CurrentPopulation_LessOrEqualsZero_ThrowArgumentException2()
        {
            Assert.Throws<System.ArgumentException>(() => Population.GetYears(-100, 0.25d, 1000, -100));
        }

        [Test]
        public void GetYearsTest_InitialPopulation_LessOrEqualsZero_ThrowArgumentException1()
        {
            Assert.Throws<System.ArgumentException>(() => Population.GetYears(-100, 0.25d, 1000, 2000000));
        }

        [Test]
        public void GetYearsTest_InitialPopulation_LessOrEqualsZero_ThrowArgumentException2()
        {
            Assert.Throws<System.ArgumentException>(() => Population.GetYears(0, 0.25d, 1000, 2000000));
        }
    }
}