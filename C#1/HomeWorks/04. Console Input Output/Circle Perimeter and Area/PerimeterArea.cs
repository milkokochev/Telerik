//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class PerimeterArea
{
    static void Main()
    {
        Console.Write("Enter radius:");
        double radius = double.Parse(Console.ReadLine());

        double circlePerimeter = Math.Round(2 * Math.PI * radius, 2);
        double circleArea = Math.Round(Math.PI * Math.Pow(radius, 2), 2);

        Console.WriteLine("Perimeter is " + circlePerimeter);
        Console.WriteLine("Area is " + circleArea);
    }
}