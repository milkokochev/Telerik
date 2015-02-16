//Write a program to calculate n! for each n in the range [1..100].


using System;
using System.Collections.Generic;


class NFactorial
{
    static List<char> Factorial(List<char> list, int number)
    {
        List<char> newfactorial = new List<char>();
        int product = 1;
        int reminder = 0;

        for (int i = list.Count-1; i >= 0; i--)
        {
            product = (((list[i] - '0') * number) % 10 + reminder);
            reminder = ((list[i] - '0') * number) / 10;
            
            newfactorial.Add(Convert.ToChar(product+'0'));
        }
        if (reminder!=0)
        {
            newfactorial.Add(Convert.ToChar(reminder+'0'));
        }
        newfactorial.Reverse();
        return newfactorial;
    }


    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            List<char> factorial = new List<char>();
            factorial.Add('1');

            for (int j = 1; j <= i; j++)
            {
                factorial=(Factorial(factorial,j));
            }

            Console.WriteLine("!{0} --> {1}",i,string.Join("",factorial));
        }
    }
}