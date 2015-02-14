//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//◦ Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ).
//◦ Prints on the console the number in reversed order:  dcba  (in our example  1102 ).
//◦ Puts the last digit in the first position:  dabc  (in our example  1201 ).
//◦ Exchanges the second and the third digits:  acbd  (in our example  2101 ).


using System;

class Number
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int digitA = number / 1000;
        int digitB = number / 100 - digitA * 10;
        int digitC = number / 10 - digitA * 100 - digitB * 10;
        int digitD = number - digitA * 1000 - digitB * 100 - digitC * 10;
        int sum = digitA + digitB + digitC + digitD;

        Console.WriteLine("sum of digits --> " + sum);
        Console.WriteLine("reversed --> {3}{2}{1}{0}", digitA, digitB, digitC, digitD);
        Console.WriteLine("last digit in front --> {3}{0}{1}{2}", digitA, digitB, digitC, digitD);
        Console.WriteLine("second and third digits exchanged --> {0}{2}{1}{3}", digitA, digitB, digitC, digitD);

    }
}