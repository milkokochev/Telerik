//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.


using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class NumberAsArray
{

    private static List<int> Reverse(BigInteger number)
    {
        List<int> newArray = new List<int>();

        while (number > 0)
        {
            newArray.Add((int)number % 10);
            number = number / 10;
        }

        return newArray;
    }
    private static List<int> AddArrays(List<int> firstList, List<int> secondList)
    {
        List<int> addedArrays = new List<int>();
        int reminder = 0;
        int sum = 0;
        bool firstIsBigger = false;

        if (firstList.Count == secondList.Count)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                sum = firstList[i] + secondList[i] + reminder;

                if (sum > 9)
                {
                    reminder = 1;
                    addedArrays.Add(sum % 10);
                }
                else
                {
                    reminder = 0;
                    addedArrays.Add(sum);
                }
            }
            if (reminder == 1)
            {
                addedArrays.Add(reminder);
                reminder = 0;
            }
        }
        else
        {
            int count = 0;
            if (firstList.Count < secondList.Count)
            {
                count = firstList.Count;
            }
            else
            {
                count = secondList.Count;
                firstIsBigger = true;
            }
            for (int i =0 ; i <count ; i++)
            {
                    sum = firstList[i] + secondList[i] + reminder;

                    if (sum > 9)
                    {
                        reminder = 1;
                        addedArrays.Add(sum % 10);
                    }
                    else
                    {
                        reminder = 0;
                        addedArrays.Add(sum);
                    }
            }
            if (firstIsBigger)
            {
                for (int i = count; i < firstList.Count; i++)
                {
                    if (reminder == 1)
                    {
                        addedArrays.Add(reminder+firstList[i]);
                        reminder = 0;
                    }
                    else
                    {
                        addedArrays.Add(firstList[i]);
                    }
                }
            }
            else
            {
                for (int i = count; i < secondList.Count; i++)
                {
                    if (reminder == 1)
                    {
                        addedArrays.Add(reminder + secondList[i]);
                        reminder = 0;
                    }
                    else
                    {
                        addedArrays.Add(secondList[i]);
                    }
                }
            }
        }
        return addedArrays;
    }
    static void Main()
    {
        Console.Write("Enter first number to add in array:");
        BigInteger firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number to add in array:");
        BigInteger secondNumber = int.Parse(Console.ReadLine());

        List<int> firstList = Reverse(firstNumber);
        List<int> secondtList = Reverse(secondNumber);

        Console.WriteLine(string.Join("", firstList));
        Console.WriteLine("+");
        Console.WriteLine(string.Join("", secondtList));
        Console.WriteLine(new string('-',15));

        List<int> output = AddArrays(firstList, secondtList);

        Console.WriteLine(string.Join("", output));
    }
}