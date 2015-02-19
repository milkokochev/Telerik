using System;

class NumberCalculations
{
    static T MinElement<T>(params T[] elements)
    {
        Array.Sort(elements);
        return elements[0];
    }

    static T MaxElement<T>(params T[] elements)
    {
        Array.Sort(elements);
        return elements[elements.Length - 1];
    }

    static T Average<T>(params T[] elements)
    {
        dynamic sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }
        return (sum / elements.Length);
    }

    static T SumElements<T>(params T[] elements)
    {
        dynamic sum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            sum += elements[i];
        }
        return sum;
    }

    static T Product<T>(params T[] elements)
    {
        dynamic product = 1;
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