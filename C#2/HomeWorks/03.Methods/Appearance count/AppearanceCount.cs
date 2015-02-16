//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;

class AppearanceCount
{
    static int count = 0;

    private static int NumberChek(int numberToCheck, int[] array)
    {
        foreach (int number in array)
        {
            if (number == numberToCheck)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the array:");
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        Console.Write("Enter the number to seek in the array:");
        int numberToCheck = int.Parse(Console.ReadLine());

        int result = NumberChek(numberToCheck, numbers);

        Console.WriteLine("Number {0} is fount {1} times in the array!", numberToCheck, result);
    }

}