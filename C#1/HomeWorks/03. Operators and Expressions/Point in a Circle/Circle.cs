//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class Circle
{
    static void Main()
    {
        double centerX = 0;
        double centerY = 0;
        double radius = 2;

        Console.Write("Enter \"X\" coordinate:");
        double pointX = double.Parse(Console.ReadLine());
        Console.Write("Enter \"Y\" coordinate:");
        double pointY = double.Parse(Console.ReadLine());

        Console.Write("Point inside the circle? --> ");

        if (Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2) <= Math.Pow(radius, 2))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}