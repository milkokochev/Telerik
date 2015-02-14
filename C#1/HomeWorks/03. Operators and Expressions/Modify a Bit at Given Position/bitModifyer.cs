//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.

using System;

class bitModifyer
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position of the Bit:");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter new value of the Bit \"0\" or \"1\" :");
        int value = int.Parse(Console.ReadLine());
        int mask = 1 << position;

        if ((number & mask) == 0)
        {
            if (value == 1)
            {
                number = number | mask;
            }
        }
        else if (value == 0)
        {
            number = number ^ mask;
        }

        Console.WriteLine(number);
    }
}