//Write an expression that checks for given integer if its third digit from right-to-left is  7 .

using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double checkNumber = 0;
        double cheker = 0;

        number = number / 100;
        checkNumber = (double)number / 10;
        cheker = Math.Round(checkNumber - number / 10, 1); // if we dont use Math.Round() the cheker will be diferent from 0.7

        if (cheker != 0.7)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }

    }
}