using System;
class Circle
{
    double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double GetLength()
    {
        return 2 * Math.PI * radius;
    }
    public double GetSquare()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Програма с классом Cicle.");
        Console.WriteLine("Разрешается вводить только числа!");
        Console.WriteLine("Введите радиус окружности:");
        double radius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        double length = circle.GetLength();
        Console.WriteLine("Длина окружности: " + length);
        double square = circle.GetSquare();
        Console.WriteLine("Площадь окружности: " + square);
        Console.WriteLine("Спасибо за использование моей программы!");
        Console.ReadLine();
    }
}