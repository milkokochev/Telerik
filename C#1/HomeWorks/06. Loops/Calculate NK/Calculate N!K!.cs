using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            int inputN = int.Parse(Console.ReadLine());
            int inputK = int.Parse(Console.ReadLine());
            BigInteger facturielK = 1;
            BigInteger facturielN = 1;

            if (inputN >= inputK && inputK > 0)
            {
                for (int i = 1; i <= inputN; i++)
                {
                    facturielN *= i;
                    if (i <= inputK)
                    {
                        facturielK *= i;
                    }
                }
                Console.WriteLine(facturielN / facturielK);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }