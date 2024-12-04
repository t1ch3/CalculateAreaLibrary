namespace CalculateAreaLibrary
{
    public class Triangle : IShape
    {
        double a { get; set; }
        double b { get; set; }
        double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Значения должны быть положительными.");
            else if (a > (b + c) || b > (a + c) || c > (a + b))
                throw new ArgumentException("Значения не образуют треугольник.");
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public double CalculateArea()
        {
            double perimeter = (a + b + c) / 2;
            double result = Math.Round(Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c)), 1);
            return result;
        }

        public bool IsRectangular()
        {
            bool check = (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                         || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                         || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            return check;
        }
    }
}
