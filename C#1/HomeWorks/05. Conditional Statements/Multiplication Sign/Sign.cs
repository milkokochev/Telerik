//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class Sign
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());

        double product = numberA * numberB * numberC;

        if (product<0)
        {
            Console.WriteLine("-");
        }
        else if (product>0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}