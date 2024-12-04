using CalculateAreaLibrary;

Console.WriteLine("Введите радиус круга");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 1-ую сторону треугольника");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 2-ую сторону треугольника");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите 3-ую сторону треугольника");
double c = Convert.ToDouble(Console.ReadLine());

Circle circle = new Circle(r);
Triangle triangle = new Triangle(a, b, c);

Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}{(triangle.IsRectangular() ? "\nПрямой треугольник" : "")}");
Console.ReadLine();
