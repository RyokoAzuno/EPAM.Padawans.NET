using NUnit.Framework;

namespace PadawansTask8.Tests
{
    [TestFixture]
    public class PublicTest
    {
        [Test]
        public void RemoveDuplicateWordsTest()
        {
            string actual = "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta";

            string expected = "alpha beta  gamma   delta       ";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDuplicateWordsTest1()
        {
            string actual = "alpha,beta.beta:gamma;gamma!gamma?delta-alpha,beta.beta:gamma;gamma!gamma?delta";

            string expected = "alpha,beta.:gamma;!?delta-,.:;!?";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDuplicateWordsTest2()
        {
            string actual = " ";
            Assert.Throws<System.ArgumentException>(() => WordsManipulation.RemoveDuplicateWords(ref actual));
        }

        [Test]
        public void RemoveDuplicateWordsTest3()
        {
            string actual = ",.:;!";

            string expected = ",.:;!";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDuplicateWordsTest4()
        {
            string actual = "...Ing  By Television And  Radio In Britain Is Regulated   Th...";

            string expected = "...Ing  By Television And  Radio In Britain Is Regulated   Th...";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDuplicateWordsTest5()
        {
            string actual = "...In  By Television And  Radio Ing Britain Is Regulated   Th...";

            string expected = "...In  By Television And  Radio Ing Britain Is Regulated   Th...";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDuplicateWordsTest6()
        {
            string actual = "... Merry.  That Is Why We Have A Lot Of  Friends. Test1 - Test1";

            string expected = "... Merry.  That Is Why We Have A Lot Of  Friends. Test1 - ";

            WordsManipulation.RemoveDuplicateWords(ref actual);

            Assert.AreEqual(expected, actual);
        }
    }
}