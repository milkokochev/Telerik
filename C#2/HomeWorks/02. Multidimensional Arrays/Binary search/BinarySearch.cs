//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.


using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter the array of numbers separated with comma \",\":");
        string[] input = Console.ReadLine().Split(',');
        Console.Write("Enter the number K:");
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int borderNumber = int.Parse(Console.ReadLine());

        Array.Sort(numbers);

        Console.WriteLine("\nSorted aray is:");
        Console.WriteLine(String.Join(",",numbers));

        int maxIndex = Array.BinarySearch(numbers, borderNumber);
        int maxNumber = numbers[maxIndex];
        Console.WriteLine("\nThe largest number in the array which is <= K is \"{0}\" with index \"{1}\" !",maxNumber,maxIndex);
    }
}