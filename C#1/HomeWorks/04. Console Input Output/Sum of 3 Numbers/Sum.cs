//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Sum
{
    static void Main()
    {
        Console.Write("Enter number A:");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number B:");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Enter number C:");
        double numberC = double.Parse(Console.ReadLine());

        double sum = numberA + numberB + numberC;

        Console.WriteLine("The sum of three numbers is " + sum);
    }
}