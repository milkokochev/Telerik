//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = 0;
 
        while (b != 0)
        {
            c = b;
            b = a % b;
            a = c;
        }
        Console.WriteLine(a);
    }
}