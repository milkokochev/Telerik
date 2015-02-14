//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix like in the examples below. Use two nested loops.

using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            for (int j = i; j < i + input; j++)
            {
                Console.Write("{0}", j);
            }
            Console.WriteLine();
        }
    }
}