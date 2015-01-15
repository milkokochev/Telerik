

using System;

class Equation
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        double x1;
        double x2;

        float D = ((b * b) - (4 * a * c));
        if (D < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (D == 0)
        {
            Console.WriteLine("x1 = x2 = " + (-b / (2 * a)));
        }
        else
        {
            x1 = (-b - Math.Sqrt(D)) / (2 * a);
            x2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}