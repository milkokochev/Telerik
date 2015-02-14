//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Side A:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Side B:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Side HEIGHT:");
        double height = double.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("Area = " + area);
    }
}