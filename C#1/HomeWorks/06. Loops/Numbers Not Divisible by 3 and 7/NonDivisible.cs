﻿//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n 
//not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NonDivisible
{
    static void Main()
    {
        int initialNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= initialNumber; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                if (i == initialNumber)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        Console.WriteLine();
    }
}