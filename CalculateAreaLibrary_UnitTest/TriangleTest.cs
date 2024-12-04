using CalculateAreaLibrary;

namespace CalculateAreaLibrary_UnitTest
{
    public class TriangleTest
    {
        [Fact]
        public void TestArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expected = 6;

            double result = triangle.CalculateArea();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FalseIsRectangular()
        {
            var triangle = new Triangle(2, 2, 4);
            Assert.False(triangle.IsRectangular());
        }

        [Fact]
        public void TrueIsRectangular()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRectangular());
        }
    }
}