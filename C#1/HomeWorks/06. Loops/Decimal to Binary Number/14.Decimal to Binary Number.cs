//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class Program
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        int modulRest;
        string binaryNumber = "";

        if (decimalNumber == 0)
        {
            Console.WriteLine(decimalNumber);
        }
        else
        {
            while (decimalNumber > 0)
            {
                modulRest = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binaryNumber = modulRest.ToString() + binaryNumber;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}