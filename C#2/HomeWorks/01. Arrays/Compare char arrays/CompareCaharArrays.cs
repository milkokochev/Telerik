//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class CompareCaharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the arrays:");
        int lenght = int.Parse(Console.ReadLine());
        char[] firstArray = new char[lenght];
        char[] secondArray = new char[lenght];
        bool equal = true;


        Console.WriteLine("Enter the elements of the first array:");
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the elements of the second array:");
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = char.Parse(Console.ReadLine());
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
