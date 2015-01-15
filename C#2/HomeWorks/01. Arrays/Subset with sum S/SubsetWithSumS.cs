//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.


using System;
using System.Collections.Generic;

class SubsetWithSumS
{
    static void Main()
    {
       

        string[] input = Console.ReadLine().Split(',');
        int sum = int.Parse(Console.ReadLine());
        
        int[] numbers = Array.ConvertAll(input,int.Parse);
        List<int> sortedNumbers= new List<int>();


        int currentSum = 0;
        int lastIndex = 0;

        bool sumFound = false;


        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];
            

            if (currentSum == sum)
            {
                sumFound = true;
                break;
            }

            else if (currentSum < sum)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    currentSum += numbers[j];
                    
                    if (currentSum == sum)
                    {
                        sumFound = true;
                        lastIndex = j;
                    }
                    else if (currentSum > sum)
                    {
                        currentSum = 0;
                        break;
                    }
                }
            }
        }
        if (sumFound)
        {
            Console.WriteLine("yes");
           
        }
        else
        {
            Console.WriteLine("no");
        }
       
    }
}