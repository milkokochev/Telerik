//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class bitExchanger
{
    static void Main()
    {
        Console.Write("Enter number:");
        uint number = uint.Parse(Console.ReadLine());
        uint temp345 = number & 7 << 3;
        uint temp242526 = number & 7 << 24;

        number = (number ^ (temp345 | temp242526)) | (temp242526 >> 21) | (temp345 << 21);

        Console.WriteLine(number);
    }
}