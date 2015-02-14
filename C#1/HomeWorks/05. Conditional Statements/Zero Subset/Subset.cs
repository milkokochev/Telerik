//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

using System;


class Subset
{
    static void Main()
    {
        bool zeroSubssetFound = false;

        string numbers = Console.ReadLine();
        string[] inputString = numbers.Split(' ');

        int[] input = new int[5];
        for (int i = 0; i < 5; i++)
        {
            input[i] = int.Parse(inputString[i]);
        }


        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (j != i)
                {
                    if (input[i] + input[j] == 0)
                    {
                        zeroSubssetFound = true;
                        Console.WriteLine("{0} + {1} = 0", input[i], input[j]);
                    }
                }
                for (int k = 0; k < input.Length; k++)
                {
                    if (j != i &&
                        k != j && k != i)
                    {
                        if (input[i] + input[j] + input[k] == 0)
                        {
                            zeroSubssetFound = true;
                            Console.WriteLine("{0} + {1} + {2} = 0", input[i], input[j], input[k]);
                        }
                    }
                    for (int l = 0; l < input.Length; l++)
                    {
                        if (j != i &&
                            k != j && k != i &&
                            l != k && l != j && l != i)
                        {
                            if (input[i] + input[j] + input[k] + input[l] == 0)
                            {
                                zeroSubssetFound = true;
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", input[i], input[j], input[k], input[l]);
                            }
                        }

                        for (int m = 0; m < input.Length; m++)
                        {
                            if (j != i &&
                                k != j && k != i &&
                                l != k && l != j && l != i &&
                                m != l && m != k && m != j && m != i)
                            {
                                if (input[i] + input[j] + input[k] + input[l] + input[m] == 0)
                                {
                                    zeroSubssetFound = true;
                                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", input[i], input[j], input[k], input[l], input[m]);
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!zeroSubssetFound)
        {
            Console.WriteLine("no zero subset");
        }
    }
}