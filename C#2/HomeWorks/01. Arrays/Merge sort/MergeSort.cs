//Write a program that sorts an array of integers using the Merge sort algorithm (find it in Wikipedia).


using System;

class MergeSort
{
    static void MergeSortedPartsOfArray(int[] array, int leftStart, int rightStart, int rightEnd, int[] result)
    {
        int leftEnd = rightStart - 1;

        for (int j = leftStart; j < rightEnd; j++)
        {
            if (leftStart <= leftEnd &&
                (rightStart >= rightEnd || array[leftStart] <= array[rightStart]))
            {
                result[j] = array[leftStart];
                leftStart++;
            }
            else
            {
                result[j] = array[rightStart];
                rightStart++;
            }
        }
    }

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        for (int i = 1; i < numbers.Length; i *= 2)
        {
            int[] result = new int[numbers.Length];

            for (int leftStart = 0; leftStart < numbers.Length; leftStart += 2 * i)
            {
                int rightStart = Math.Min(leftStart + i, numbers.Length);
                int rightEnd = Math.Min(leftStart + (2 * i), numbers.Length);
                MergeSortedPartsOfArray(numbers, leftStart, rightStart, rightEnd, result);
            }
            numbers = result;
        }

        Console.WriteLine(string.Join(", ", numbers));
    }
}