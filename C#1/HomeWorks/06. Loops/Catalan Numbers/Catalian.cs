//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).
//using System;
using System;
using System.Numerics;

class Catalian
{
    static void Main()
    {
        int inputN = int.Parse(Console.ReadLine());

        BigInteger facturielDoubleN = 1;
        BigInteger facturielN = 1;
        BigInteger facturielNplusOne = 1;
        BigInteger catalianNumber = 0;

        if (inputN >= 0)
        {
            for (int i = 1; i <= inputN * 2; i++)
            {
                facturielDoubleN *= i;
                if (i <= inputN)
                {
                    facturielN *= i;
                }
                if (i <= (inputN + 1))
                {
                    facturielNplusOne *= i;
                }
            }
            catalianNumber = facturielDoubleN / (facturielNplusOne * facturielN);
            Console.WriteLine(catalianNumber);
        }
    }
}