//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.


using System;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter lenght of the array N:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter lenght of the subset K:");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter sum S:");
        int sum = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Enter elements of the array:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int currentSum = 0;
        int count = 0;
        int lastIndex = 0;

        bool sumFound = false;


        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            count = 1;

            if (currentSum == sum)
            {
                currentSum = 0;
                continue;
            }

            else if (currentSum < sum)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    currentSum += numbers[j];
                    count++;

                    if (currentSum == sum && count == k)
                    {
                        sumFound = true;
                        lastIndex = j;
                    }
                    else if (currentSum > sum || count >= k)
                    {
                        currentSum = 0;
                        break;
                    }
                }
            }
        }
        if (sumFound)
        {
            Console.Write("yes --> ");
            for (int i = lastIndex + 1 - k; i <= lastIndex; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}