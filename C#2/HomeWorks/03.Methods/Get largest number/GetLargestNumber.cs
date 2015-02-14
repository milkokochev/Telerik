//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().


using System;

class GetLargestNumber
{

    static int GetMax(int a, int b)
    {
        if (a>=b)
        {
            return a;
        }
        else
        {
            return b;
        }

    }
    static void Main()
    {
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondnumber = int.Parse(Console.ReadLine());

        int maxNumber = GetMax(firstNumber, secondnumber);
        Console.WriteLine("Larger number is {0}",maxNumber);
    }
}