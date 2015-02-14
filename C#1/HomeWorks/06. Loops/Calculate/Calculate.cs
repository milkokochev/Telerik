//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

    class Calculate
    {
        static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            int inputX = int.Parse(Console.ReadLine());
            int facturiel = 1;
            float sum = 1;

            for (int i = 1; i <= inputN; i++)
            {
                facturiel *= i;
                sum += (float)(facturiel / Math.Pow(inputX, i));
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }