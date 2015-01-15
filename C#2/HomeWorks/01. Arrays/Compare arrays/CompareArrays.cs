//Write a program that reads two integer arrays from the console and compares them element by element.


using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the arrays:");
        int lenght = int.Parse(Console.ReadLine());
        int[] firstArray = new int[lenght];
        int[] secondArray = new int[lenght];
        bool equal = true;


        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equal = false;
                break;
            }
        }
        Console.WriteLine("Are both arrays equal? --> " + equal);
    }
}