using System;

class CombinationsOfSset
{    
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Main()
    {
        int[] numbersK = new int[k];
        Combinations(numbersK,0,1);
    }

    static void Combinations(int[] array, int index, int currentNumber)
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
            for (int i = currentNumber; i <= n; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i+1);
            }
        }
    }
}