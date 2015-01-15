//Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = new int[input.Length];
       
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int maxSum = numbers[0];
        int currentSum = numbers[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            if (currentSum< numbers[i])
            {
                currentSum = numbers[i];
                tempIndex = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = tempIndex;
                endIndex = i;
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.WriteLine("{0}", numbers[i]);
            }
            else
            {
                Console.Write("{0},", numbers[i]);
            }
        }

    }
}