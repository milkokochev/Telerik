//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Text;


class PrimeNumbers
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i <= 10000000; i++)
        {
            numbers.Add(i);
        }

        for (int i = 0; i < Math.Sqrt(numbers.Count); i++)
        {
            if (numbers[i] == 0 || numbers[i] == 1)
            {
                numbers[i] = 0;
            }
            else if (numbers[i] != 0)
            {
                for (int j = i * i; j < numbers.Count; j += i)
                {
                    numbers[j] = 0;
                }
            }
        }
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] != 0)
            {
               output.Append(numbers[i]).Append(" ");
            }
        }
        Console.WriteLine(output);
    }
}