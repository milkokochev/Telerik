//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeCheker
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number < 2)
        {
            Console.WriteLine("false");
        }
        else if (number == 2)
        {
            Console.WriteLine("true");
        }
        else
        {
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("false");
                }
            }
            Console.WriteLine("true");
        }
    }
}