//       Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

namespace _11._12.AddSubstractMultiplyPolynomials
{
    class Program
    {
        static int lenght = 0;
        static int[] coefficients = new int[lenght];
        static int[] result;
        static int[] firstPolinomial = CreatingPolinomial();
        static int[] secondPolinomial = CreatingPolinomial();


        static int[] CreatingPolinomial()
        {
            Console.Write("Enter lenght of polinomial: ");
            lenght = int.Parse(Console.ReadLine());
            coefficients = new int[lenght];

            for (int i = lenght - 1; i >= 0; i--)
            {
                Console.Write("x^{0} = ", i);
                coefficients[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return coefficients;
        }

        static void PrintPolinomial(int[] coefficients)
        {
            for (int i = coefficients.Length - 1; i >= 0; i--)
            {
                if (coefficients[i] == 0)
                {
                    continue;
                }
                if (i == 0)
                {
                    Console.Write(coefficients[i]);
                }
                else if (i == 1)
                {
                    Console.Write("{0}x", coefficients[i]);
                }
                else
                {
                    Console.Write("{0}x^{1}", coefficients[i], i);
                }
                if (i > 1)
                {
                    if (coefficients[i - 1] < 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" + ");
                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] SumPolinomials()
        {
            int minLength = Math.Min(firstPolinomial.Length, secondPolinomial.Length);
            int maxLength = Math.Max(firstPolinomial.Length, secondPolinomial.Length);
            result = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                if (i < minLength)
                {
                    result[i] = firstPolinomial[i] + secondPolinomial[i];
                }
                else if (i > firstPolinomial.Length - 1)
                {
                    result[i] = secondPolinomial[i];
                }
                else if (i > secondPolinomial.Length - 1)
                {
                    result[i] = firstPolinomial[i];
                }
            }
            return result;
        }

        static int[] SubtractionPolinomials()
        {
            int minLength = Math.Min(firstPolinomial.Length, secondPolinomial.Length);
            int maxLength = Math.Max(firstPolinomial.Length, secondPolinomial.Length);
            result = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                if (i < minLength)
                {
                    result[i] = firstPolinomial[i] - secondPolinomial[i];
                }
                else if (i > firstPolinomial.Length - 1)
                {
                    result[i] = -secondPolinomial[i];
                }
                else if (i > secondPolinomial.Length - 1)
                {
                    result[i] = firstPolinomial[i];
                }
            }
            return result;
        }

        static void MultiplicationPolinomials()
        {
            result = new int[firstPolinomial.Length + secondPolinomial.Length];

            for (int i = firstPolinomial.Length - 1; i >= 0; i--)
            {
                for (int j = secondPolinomial.Length - 1; j >= 0; j--)
                {
                    result[i + j] = firstPolinomial[i] * secondPolinomial[j];

                    if (result[i + j] == 0)
                    {
                        continue;
                    }
                    if (i + j == 0)
                    {
                        Console.Write(result[i + j]);
                    }
                    else if (i + j == 1)
                    {
                        Console.Write("{0}x", result[i + j]);
                    }
                    else
                    {
                        Console.Write("{0}x^{1} ", result[i + j], i + j);
                    }
                    if (i + j > 0)
                    {
                        if (result[i + j - 1] < 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(" + ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main()
        {

            Console.WriteLine("First polinomial is: ");
            PrintPolinomial(firstPolinomial);

            Console.WriteLine("Second polinomial is: ");
            PrintPolinomial(secondPolinomial);

            Console.WriteLine("Sum of polinomials:");
            SumPolinomials();
            PrintPolinomial(result);

            Console.WriteLine("Subtraction of polinomials: ");
            SubtractionPolinomials();
            PrintPolinomial(result);

            Console.WriteLine("Multiplication of polinomials: ");
            MultiplicationPolinomials();

        }
    }
}