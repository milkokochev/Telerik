//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

    class BiggestOfFive
    {
        static void Main()
        {
            double[] numbers = new double[5];
            double biggest = new double();

            Console.WriteLine("Enter three numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }

            biggest = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (biggest < numbers[i])
                {
                    biggest = numbers[i];
                }
            }

            Console.Write("The biggest number is:");
            Console.WriteLine(biggest);
        }
    }