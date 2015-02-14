//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

class SortNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a < b)
        {
            if (b < c)
            {
                if (a < c)
                {
                    a = c + a;
                    c = a - c;
                    a = a - c;
                }
                //else --> a < b < c < a - impossible case
            }
            else if (a < c)
            {
                a = c + a;
                c = a - c;
                a = a - c;

                a = b + a;
                b = a - b;
                a = a - b;
            }
            else
            {
                a = b + a;
                b = a - b;
                a = a - b;
            }
        }
        else if (b < c)
        {
            if (a < c)
            {
                a = c + a;
                c = a - c;
                a = a - c;

                b = c + b;
                c = b - c;
                b = b - c;
            }
            else
            {
                b = c + b;
                c = b - c;
                b = b - c;
            }
        }
        Console.WriteLine("{0} {1} {2}", a, b, c);
    }
}