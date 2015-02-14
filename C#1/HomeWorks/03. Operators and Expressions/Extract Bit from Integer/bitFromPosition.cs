//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class bitFromPosition
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the Bit:");
        int position = int.Parse(Console.ReadLine());

        number = number >> position;
        number = number & 1;

        Console.WriteLine(number);
    }
}