//Write a program that reads an array of integers and removes from it a minimal number of elements 
//in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

using System;
using System.Collections.Generic;

class RemoveElementsFromArray
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        int[]numbers = Array.ConvertAll(input, int.Parse);

        List<int> result = new List<int>();

        int maxi = (int)Math.Pow(2, numbers.Length) - 1;
        int maxElements = 0;
        bool isSorted = true;
        int counter = 0;


        for (int i = 1; i <= maxi; i++)
        {
            isSorted = true;

            List<int> temporaryList = new List<int>();
            counter = 0;

            for (int j = 0; j <= numbers.Length; j++)
            {
                if (((i >> (j)) & 1) == 1)
                {
                    temporaryList.Add(numbers[j]);
                    counter++;
                }
            }

            for (int m = 0; m < temporaryList.Count - 1; m++)
            {
                if (temporaryList[m] > temporaryList[m + 1])
                {
                    isSorted = false;
                }
            }

            if (counter > maxElements && (isSorted == true))
            {
                result = temporaryList;
                maxElements = counter;
            }

            counter = 0;
        }

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}