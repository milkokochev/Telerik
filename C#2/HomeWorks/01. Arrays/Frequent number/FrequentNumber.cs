//Write a program that finds the most frequent number in an array.


using System;

class FrequentNumber
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
        int element = numbers[0];
        int maxCount = 0;

        Array.Sort(numbers);

        for (int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i]==numbers[i+1])
            {
                count++;
            }
            else
            {
                if (maxCount<count)
                {
                    maxCount = count;
                    element = numbers[i];
                }
                count = 1;
            }
            if (maxCount < count)
            {
                maxCount = count;
                element = numbers[i];
            }
        }
        Console.WriteLine("{0}({1}times)", element, maxCount);
    }
}