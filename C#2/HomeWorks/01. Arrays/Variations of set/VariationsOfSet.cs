using System;

class VariationsOfSet
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[] numbersK = new int[k];
        Variations(numbersK,0);
    }

    static void Variations(int[] array, int index)
    {
        if (index == array.Length)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                array[index] = i;
                Variations(array, index + 1);
            }
        }
    }
}