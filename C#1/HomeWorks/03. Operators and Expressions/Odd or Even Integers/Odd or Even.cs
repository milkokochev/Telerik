//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.Write("Is the number \""+ number+"\" ODD? --> ");

        if (number%2==0)
        {
            Console.WriteLine("false");  
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}