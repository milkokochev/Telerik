

using System;

    class SumOfN
    {
        static void Main()
        {
            float sumOfNumbers = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sumOfNumbers += float.Parse(Console.ReadLine());
            }

            Console.WriteLine(sumOfNumbers);
        }
    }