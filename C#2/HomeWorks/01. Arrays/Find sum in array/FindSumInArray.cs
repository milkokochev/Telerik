//Write a program that finds in given array of integers a sequence of given sum S (if present).


using System;
using System.Collections.Generic;

    class FindSumInArray
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(',');
            int sum = int.Parse(Console.ReadLine());

            int[] numbers = new int[input.Length];
            List<int> sequencesEqualToSum = new List<int>();

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
                if (currentSum > sum)
                {
                    currentSum = numbers[i];
                    tempIndex = i;
                }
                if (currentSum == sum)
                {
                    maxSum = currentSum;
                    startIndex = tempIndex;
                    endIndex = i;

                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        sequencesEqualToSum.Add(numbers[j]);        //add element to List and colect all sequences equal to sum
                    }
                }
            }

            for (int i = 0; i < sequencesEqualToSum.Count; i++)
            {
                if (i == sequencesEqualToSum.Count-1)
                {
                    Console.WriteLine("{0}", sequencesEqualToSum[i]);
                }
                else
                {
                    Console.Write("{0},", sequencesEqualToSum[i]);
                }
            }
        }
    }