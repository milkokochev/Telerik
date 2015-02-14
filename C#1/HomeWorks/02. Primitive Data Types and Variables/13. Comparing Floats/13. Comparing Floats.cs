using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double firstNum;
        double secondNum;
        double diff;

        Console.WriteLine("Enter the first number to compare: ");
        double.TryParse(Console.ReadLine(), out firstNum);

        Console.WriteLine("Enter the second number to compare: ");
        double.TryParse(Console.ReadLine(), out secondNum);
        

        diff = Math.Abs(firstNum - secondNum);

        if (diff < 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}