using NUnit.Framework;

namespace PadawansTask11.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase(new[] { 0.0001, 1.0002, -0.0003, 1, 0.0003, 1, -0.0003 }, 0.001, ExpectedResult = 3)]
        [TestCase(new[] { 0.0001, 1.0002, -0.0003, 1, 0.0003, 1, -0.0003 }, 1E-06d, ExpectedResult = 3)]
        [TestCase(new[] { double.MaxValue, 1.0d, double.MaxValue }, 4.94065645841247E-324d, ExpectedResult = 1)]
        [TestCase(new[] { double.MinValue, 1.0d, double.MinValue }, 4.94065645841247E-324d, ExpectedResult = 1)]
        [TestCase(new[] { double.MaxValue, double.MinValue, 1.0d, double.MaxValue, double.MinValue }, 4.94065645841247E-324d, ExpectedResult = 2)]
        //[TestCase(new[] { 0.0001, 1.0002, -0.0003, 1, 0.0003, 1, -0.0003 }, 4.94065645841247E-324d, ExpectedResult = null)]
        [TestCase(new[] { 1.0001, 1.0002, -3.0003, 1, 0.0003, 8.9, -0.0003, 0.901 }, 0.001, ExpectedResult = null)]
        [TestCase(new[] { 1.0001, 1.0002, -3.0003, 1, 0.0003, 8.9, -0.0003, 0.901 }, 0.002d, ExpectedResult = null)]
        public int? FindIndexTests(double[] array, double accuracy)
            => ArrayExtensions.FindIndex(array, accuracy);

        [Test]
        public void My_FindIndexTest_ArrayIsEmpty_ThrowArgumentException()
        {
            double[] array = {};
            double accuracy = 0.001d;

            Assert.Throws<System.ArgumentException>(() 
            => ArrayExtensions.FindIndex(array, accuracy));
        }

        [Test]
        public void My_FindIndexTest_ArrayIsEmpty_ThrowArgumentOutOfRangeException()
        {
            double[] array = { 0.0001, 1.0002, -0.0003, 1, 0.0003, 1, -0.0003 };
            double accuracy1 = 1.5d;
            double accuracy2 = -4.9d;
            double accuracy3 = 0;
            double accuracy4 = 1;
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, accuracy1));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, accuracy2));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, accuracy3));
            Assert.Throws<System.ArgumentOutOfRangeException>(() => ArrayExtensions.FindIndex(array, accuracy4));
        }

        [Test]
        public void My_FindIndexTest_ArrayIsNull_ThrowArgumentNullException()
        {
            double[] array = null;
            double accuracy = 0.001d;

            Assert.Throws<System.ArgumentNullException>(()
            => ArrayExtensions.FindIndex(array, accuracy));
        }

    }
}