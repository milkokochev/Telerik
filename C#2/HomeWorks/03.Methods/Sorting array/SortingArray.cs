//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.


using System;

class SortingArray
{
    static int FindMaxNumber(int[] array, int startIndex, int endIndex)
    {
        int maxIndex = startIndex;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }

    static void SortDescending(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = FindMaxNumber(array, i, array.Length);
            int temp = array[maxIndex];
            array[maxIndex] = array[i];
            array[i] = temp;
        }
    }

    static void SortAscending(int[] array)
    {
        for (int i = 0; i <array.Length; i++)
        {
            int maxIndex = FindMaxNumber(array, 0, array.Length-i);
            int temp = array[maxIndex];
            array[maxIndex] = array[array.Length -1- i];
            array[array.Length - 1 - i] = temp;
        }
    }
    
    static void Main()
    {
        Console.Write("Enter the array each elemen separated with comma:");
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        SortAscending(numbers);
        Console.Write("sorts an array in ascending order --> ");
        Console.WriteLine(String.Join("",numbers));

        SortDescending(numbers);
        Console.Write("sorts an array in descending order --> ");
        Console.WriteLine(String.Join("", numbers));

    }
}