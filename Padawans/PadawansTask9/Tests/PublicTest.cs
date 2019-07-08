using System.Collections.Generic;
using NUnit.Framework;

namespace PadawansTask9.Tests
{
    [TestFixture]
    public class PublicTest
    {
        private Point[] points;

        private static IEnumerable<TestCaseData> DataCases
        {
            get
            {
                yield return new TestCaseData(2, new List<Point> {
                                                                    new Point(3, 4),
                                                                    new Point(4, 4),
                                                                    new Point(2, 3),
                                                                    new Point(2, 2),
                                                                    new Point(5, 2)
                                                                  });
                yield return new TestCaseData(1, new List<Point> {
                                                                    new Point(3, 4),
                                                                    new Point(4, 4),
                                                                    new Point(2, 3),
                                                                    new Point(2, 2)
                                                                  });
            }
        }

        [SetUp]
        public void Init()
        {
            points = new Point[]
            {
                new Point(-2, 5),
                new Point(6, 6),
                new Point(3, 4),
                new Point(4, 4),
                new Point(2, 3),
                new Point(2, 2),
                new Point(5, 2),
                new Point(3, -2),
            };
        }

        [TestCaseSource(nameof(DataCases))]
        public void GetNeighborsTests(int range, List<Point> expected)
        {
            var point = new Point(3, 3);

            var actual = CartesianCoordinates.GetNeighbors(point, range, this.points);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [Test]
        public void My_GetNeighbors_IfRangeLessOrEqualsZero_ThrowArgumentException()
        {
            var point = new Point(3, 3);
            Assert.Throws<System.ArgumentException>(() => CartesianCoordinates.GetNeighbors(point, 0, this.points));
            Assert.Throws<System.ArgumentException>(() => CartesianCoordinates.GetNeighbors(point, -7, this.points));
        }

        [Test]
        public void My_GetNeighbors_IfPointsIsEqualNull_ThrowArgumentNullException()
        {
            var point = new Point(3, 3);
            Assert.Throws<System.ArgumentNullException>(() => CartesianCoordinates.GetNeighbors(point, 5, null));
        }
    }
}
