using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.UnicodeEncoding.Unicode;
        Console.BufferHeight = 257;

        Console.WriteLine("The characters in ANSI Table are:");

        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine(i + " - " + (char)i);
        }
    }
}