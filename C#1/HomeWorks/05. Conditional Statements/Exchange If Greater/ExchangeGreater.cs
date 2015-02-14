//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

using System;

class ExchangeGreater
{
    static void Main()
    {
        Console.Write("Enter number \"a\":");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter number \"b\":");
        double numberB = double.Parse(Console.ReadLine());

        if (numberA < numberB)
        {
            numberA = numberA + numberB;
            numberB = numberA - numberB;
            numberA = numberA - numberB;
        }

        Console.WriteLine("Number \"a\"=" + numberA);
        Console.WriteLine("Number \"b\"=" + numberB);
    }
}