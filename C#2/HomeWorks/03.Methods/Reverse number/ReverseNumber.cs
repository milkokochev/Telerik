//Write a method that reverses the digits of given decimal number.


using System;
using System.Text;

class ReverseNumber
{
    static StringBuilder output = new StringBuilder();

    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();

        Reverse(input);

        Console.WriteLine(output);


    }

    private static void Reverse(char[] input)
    {
        output.Clear();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            output.Append(input[i]);
        }
    }
}