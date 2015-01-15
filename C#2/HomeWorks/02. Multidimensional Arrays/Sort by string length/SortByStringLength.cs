//You are given an array of strings. Write a method that sorts the array by the 
//length of its elements (the number of characters composing them).


using System;

class SortByStringLength
{
    static void Main()
    {
        Console.WriteLine("Enter the array of strings separated with comma \",\":");
        string[] input = Console.ReadLine().Split(',');

        // using selection sort algorithm for strings lenght
        for (int i = 0; i < input.Length; i++)
        {
            int minIndex = i;
            for (int j = i; j < input.Length; j++)
            {
                if (input[j].Length < input[minIndex].Length)
                {
                    minIndex = j;
                }
            }
            string temp = input[minIndex];
            input[minIndex] = input[i];
            input[i] = temp;
        }
        Console.WriteLine();
        Console.WriteLine(String.Join(", ", input));
    }
}