using NUnit.Framework;

namespace PadawansTask5.Tests
{
    [TestFixture]
    public class PublicTest
    { 
        [TestCase(arg: new[] { 1, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1 }, ExpectedResult = "Yes")]
        [TestCase(arg: new[] { 1, 1, 0, 0, 0, 0, 1, 1, 0 }, ExpectedResult = "No")]

        public string CheckIfSymmetricTests(int[] source) => ArrayHelper.CheckIfSymmetric(source);

        [Test]
        public void My_CheckIfSymmetric_Source_IsEmptyArray_Throw_ArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => ArrayHelper.CheckIfSymmetric(new int[] { }));
        }

        [Test]
        public void My_CheckIfSymmetric_Source_IsNull_Throw_ArgumentNullException()
        {
            Assert.Throws<System.ArgumentNullException>(() => ArrayHelper.CheckIfSymmetric(null));
        }
    }
}
