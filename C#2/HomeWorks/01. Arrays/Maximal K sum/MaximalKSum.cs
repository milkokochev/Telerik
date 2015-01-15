//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter the number of elements of the array:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of elements to clculate maximal sum:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements of the array:");

        int[] numbers = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        for (int i = 1; i <= k; i++)
        {
            Console.WriteLine("Number {0} --> {1}",i, numbers[numbers.Length-k+i-1]);
            sum += numbers[numbers.Length - k+i -1];
        }
        Console.WriteLine(sum);
    }
}