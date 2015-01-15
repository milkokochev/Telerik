//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        int fibonacciNumber = 1;

        if (n == 1)
        {
            Console.WriteLine(firstNumber);
        }
        else if (n == 2)
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.Write(firstNumber);

            for (int i = 1; i < n; i++)
            {
                Console.Write(" {0}", fibonacciNumber);
                fibonacciNumber += firstNumber;
                firstNumber = fibonacciNumber - firstNumber;
            }
            Console.WriteLine();
        }
    }
}