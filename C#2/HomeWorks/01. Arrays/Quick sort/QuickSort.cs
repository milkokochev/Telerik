//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;
using System.Collections.Generic;


namespace Quick_sort
{
    class QuickSort_
    {
        static List<char> QuickSort(List<char> array)
        {
            if (array.Count <= 1)
            {
                return array;
            }

            char pivot = array[array.Count / 2];
            List<char> less = new List<char>();
            List<char> greater = new List<char>();

            for (int i = 0; i < array.Count; i++)
            {
                if (i != (array.Count / 2))
                {
                    if (array[i] <= pivot)
                    {
                        less.Add(array[i]);
                    }
                    else
                    {
                        greater.Add(array[i]);
                    }
                }
            }

            return ConcatenateArrays(QuickSort(less), pivot, QuickSort(greater));
        }

        static List<char> ConcatenateArrays(List<char> less, char pivot, List<char> greater)
        {
            List<char> result = new List<char>();

            for (int i = 0; i < less.Count; i++)
            {
                result.Add(less[i]);
            }

            result.Add(pivot);

            for (int i = 0; i < greater.Count; i++)
            {
                result.Add(greater[i]);
            }

            return result;
        }

        static void PrintList(List<char> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(',');
            char[] inputChars = Array.ConvertAll(input,char.Parse);

            List<char> arrayOfIntegers = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                arrayOfIntegers.Add(inputChars[i]);
            }
            List<char> sortedArray = QuickSort(arrayOfIntegers);

            PrintList(sortedArray);
        }
    }
}
