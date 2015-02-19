//Write a program to calculate n! for each n in the range [1..100].


using System;
using System.Collections.Generic;


class NFactorial
{
    static List<char> Factorial(List<char> list, int number)  // litle complicated, but i want to do it without recursion and BigIntiger
    {
        List<char> newfactorial = new List<char>();
        int product = 1;
        int reminder = 0;

        if (number==0)
        {
            newfactorial.Add( Convert.ToChar(product + '0'));
        }
        else
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                product = (((list[i] - '0') * number) % 10 + reminder);
                reminder = ((list[i] - '0') * number) / 10;

                while (product >= 10)
                {
                    reminder = reminder + product / 10;
                    product = product % 10;
                }

                newfactorial.Add(Convert.ToChar(product + '0'));
            }

            while (reminder != 0)
            {
                if (reminder >= 10)
                {
                    newfactorial.Add(Convert.ToChar((reminder % 10) + '0'));

                }
                else
                {
                    newfactorial.Add(Convert.ToChar(reminder + '0'));
                }
                reminder /= 10;
            }

            newfactorial.Reverse();
        }
        return newfactorial;
        
    }


    static void Main()
    {
        List<char> factorial = new List<char>();

            for (int i = 0; i <= 100; i++)
            {
                factorial = (Factorial(factorial, i));
                Console.WriteLine("{0,4}! --> {1}", i, string.Join("", factorial));
            }
    }
}