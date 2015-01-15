//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.


using System;

class SelectionSort
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int minIndex;
        int temp;

        for (int i = 0; i < numbers.Length; i++)
        {
            minIndex = i;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == numbers.Length - 1)
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