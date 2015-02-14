//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.


using System;

    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int input = int.Parse(Console.ReadLine());
            float sum = input;
            int minimumInput = input;
            int maximumInput = input;

            for (int i = 1; i < numberOfInputs; i++)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
                if (input < minimumInput)
                {
                    minimumInput = input;
                }
                if (input > maximumInput)
                {
                    maximumInput = input;
                }
            }
            float average = (float)(sum / numberOfInputs);
            Console.WriteLine("min = " + minimumInput);
            Console.WriteLine("max = " + maximumInput);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avg = {0:F2}", average);
        }
    }