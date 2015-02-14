﻿//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class Program
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '0')
            {
                continue;
            }
            decimalNumber += (long)Math.Pow(2, i);
        }
        Console.WriteLine(decimalNumber);
    }
}