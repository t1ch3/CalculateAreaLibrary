using CalculateAreaLibrary;

namespace CalculateAreaLibrary_UnitTest
{
    public class CircleTest
    {
        [Fact]
        public void TestArea()
        {
            Circle circle = new Circle(6);
            double expected = 113.1;

            double result = circle.CalculateArea();

            Assert.Equal(expected, result);
        }
    }
}
