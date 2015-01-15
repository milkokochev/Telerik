//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfFive
{
    static void Main()
    {
        float sumOfNumbers = 0;

        string fiveNumbers = Console.ReadLine();
        string[] valuesOfNumbers = fiveNumbers.Split(' ');

        for (int i = 0; i < 5; i++)
        {
            sumOfNumbers += float.Parse(valuesOfNumbers[i]);
        }

        Console.WriteLine(sumOfNumbers);
    }
}