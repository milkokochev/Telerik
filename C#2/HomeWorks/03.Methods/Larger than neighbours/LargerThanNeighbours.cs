//Write a method that checks if the element at given position in given array of 
//integers is larger than its two neighbours (when such exist).


using System;

class LargerThanNeighbours
{

    static bool NeighborsComparer(int index, int[] array)
    {
        bool maxIndex = false;
        if (index == 0 && array[index] > array[index + 1])
        {
            maxIndex = true;
        }
        else if (index == array.Length - 1 && array[index] < array[index - 1])
        {
            maxIndex = true;
        }
        else if (index > 0 && array[index - 1] < array[index] && array[index + 1] < array[index] && index < array.Length - 1)
        {
            maxIndex = true;
        }

        return maxIndex;
    }

    static void Main()
    {
        Console.Write("Enter the array:");
        string[] input = Console.ReadLine().Split(',');
        int[] numbers = Array.ConvertAll(input, int.Parse);

        Console.Write("Enter the index number to compare with its neighbors in the array:");
        int indexToCheck = int.Parse(Console.ReadLine());

        bool maxIndex = NeighborsComparer(indexToCheck, numbers);

        if (numbers.Length == 1)
        {
            Console.WriteLine("Array has only one element!");

        }
        else if (maxIndex)
        {
            Console.WriteLine("The number {0} with index {1} is greater then its neighbors!", numbers[indexToCheck], indexToCheck);
        }
        else
        {
            Console.WriteLine("The number {0} with index {1} is NOT greater then its neighbors!", numbers[indexToCheck], indexToCheck);

        }      
    }
}