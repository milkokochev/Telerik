//Write a program that finds the maximal increasing sequence in an array.


using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int count = 1;
        int endIndex = 0;
        int sequenceLenght = 0;
        int[] sequence = new int[input.Length];

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                count++;
            }
            else
            {
                if (sequenceLenght < count)
                {
                    sequenceLenght = count;
                    endIndex = i;
                }
                count = 1;
            }
        }

        if (sequenceLenght < count)
        {
            sequenceLenght = count;
            endIndex = numbers.Length - 1;
        }

        for (int i = endIndex - sequenceLenght + 1; i <= endIndex; i++)
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