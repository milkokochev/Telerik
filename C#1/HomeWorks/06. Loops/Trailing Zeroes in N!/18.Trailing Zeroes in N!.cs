//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zeros = 0;
        int five = 5;

        while (five < n)
        {
            zeros += n / five;
            five = five * 5;
        }
        Console.WriteLine(zeros);
    }
}