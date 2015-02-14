//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class Program
{
    static void Main(string[] args)
    {
        string numbers = Console.ReadLine();
        string[] input = numbers.Split(' ');
        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= Convert.ToInt32(input[i]);
            }
            else
            {
                productEven *= Convert.ToInt32(input[i]);
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes \nproduct = {0}", productOdd);
        }
        else
        {
            Console.WriteLine("no \nodd_product = {0}\neven_product = {1}", productOdd, productEven);
        }
    }
}