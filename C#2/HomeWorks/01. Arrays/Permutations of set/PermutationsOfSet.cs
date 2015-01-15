using System;
using System.Collections.Generic;

class PermutationsOfSet
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array:");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i+1;
        }

        Permute(numbers, 0, numbers.Length);

    }

    static void Permute(int[] numbers, int current, int length)
    {
        if (current == length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = current; i < length; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[current];
                numbers[current] = temp;

                Permute(numbers, current + 1, length);

                temp = numbers[i];
                numbers[i] = numbers[current];
                numbers[current] = temp;
            }
        }
    }
}