//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


using System;
using System.Numerics;


    class IntegerCalculations
    {
        static int MinElement(params int[] elements)
        {
            Array.Sort(elements);
            return elements[0];
        }

        static int MaxElement(params int[] elements)
        {
            Array.Sort(elements);
            return elements[elements.Length - 1];
        }

        static double Average(params int[] elements)
        {
            return SumElements(elements) * 1.0 / elements.Length;
        }

        static long SumElements(params int[] elements)
        {
            long sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return sum;
        }

        static BigInteger Product(params int[] elements)
        {
            BigInteger product = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                product *= elements[i];
            }
            return product;
        }

        static void Main()
        {
            Console.Write("Enter the array each elemen separated with comma:");
            string[] input = Console.ReadLine().Split(',');
            int[] numbers = Array.ConvertAll(input, int.Parse);

            Console.WriteLine("Min element:   {0,-0}", MinElement(numbers));
            Console.WriteLine("Max element:   {0,-0}", MaxElement(numbers));
            Console.WriteLine("Average value: {0,-0:0.0}", Average(numbers));
            Console.WriteLine("Sum value:     {0,-0}", SumElements(numbers));
            Console.WriteLine("Product value: {0,-0}", Product(numbers));
        }
    }
