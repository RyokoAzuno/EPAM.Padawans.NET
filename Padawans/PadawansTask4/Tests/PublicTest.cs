using NUnit.Framework;

namespace PadawansTask4.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [TestCase("abracadabra", ExpectedResult = 5)]
        [TestCase("sprppr", ExpectedResult = 0)]
        [TestCase("aaa", ExpectedResult = 3)]
        public int GetVowelCountTests(string source) => StringHelper.GetVowelCount(source);

        [Test]
        public void My_GetVowelCount_String_IsEmpty_Throw_ArgumentException()
        {
            Assert.Throws<System.ArgumentException>(() => StringHelper.GetVowelCount(""));
        }

        [Test]
        public void My_GetVowelCount_String_IsNull_Throw_ArgumentNullException()
        {
            Assert.Throws<System.ArgumentNullException>(() => StringHelper.GetVowelCount(null));
        }
    }
}