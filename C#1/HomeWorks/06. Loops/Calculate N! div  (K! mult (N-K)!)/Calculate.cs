//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

    class Calculate
    {
        static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            int inputK = int.Parse(Console.ReadLine());
            BigInteger facturielK = 1;
            BigInteger facturielN = 1;
            BigInteger facturielNMinusK = 1;
            BigInteger numberOfCombinations = 0;

            if (inputN >= inputK && inputK > 0)
            {
                for (int i = 1; i <= inputN; i++)
                {
                    facturielN *= i;
                    if (i <= inputK)
                    {
                        facturielK *= i;
                    }
                    if (i <= inputN - inputK)
                    {
                        facturielNMinusK *= i;
                    }
                }
                numberOfCombinations = facturielN / (facturielK * facturielNMinusK);
                Console.WriteLine(numberOfCombinations);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }