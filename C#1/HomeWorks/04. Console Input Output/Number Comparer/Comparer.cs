//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class Comparer
{
    static void Main()
    {
        Console.Write("Enter first number to compare:");
        double numberA = double.Parse(Console.ReadLine());

        Console.Write("Enter second number to compare:");
        double numberB = double.Parse(Console.ReadLine());

        Console.Write("The greater number is:");
        Console.WriteLine(numberA > numberB ? numberA : numberB);
    }
}