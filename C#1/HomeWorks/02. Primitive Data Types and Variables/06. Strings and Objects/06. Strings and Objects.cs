using System;

class Program
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object firstObject = firstString + " " + secondString;
        string thirdString = (string)firstObject;

        Console.WriteLine(thirdString);
    }
}