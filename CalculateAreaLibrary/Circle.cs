namespace CalculateAreaLibrary
{
    public class Circle : IShape
    {
        double Radius { get; set; }

        public Circle(double Radius)
        {
            if (Radius <= 0)
                throw new ArgumentException("Значения должны быть положительными.");
            else
                this.Radius = Radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
