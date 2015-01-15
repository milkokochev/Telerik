//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("How many rows will have the matrix? :");
        int rowsInput = int.Parse(Console.ReadLine());
        Console.Write("How many colums will have the matrix? :");
        int columsInput = int.Parse(Console.ReadLine());

        int[,] inputMatrix = new int[rowsInput, columsInput];
        
        Console.WriteLine("Enter elements of the matrix:");

        for (int row = 0; row < rowsInput; row++)
        {
            for (int col = 0; col < columsInput; col++)
            {
                Console.Write("Element [{0},{1}]:",row,col);
                inputMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int squareSize = 3;
        int maxSum = int.MinValue;
        int currentSum = 0;
        int maxRow = 0;
        int maxCol = 0;

        // finding the maximal sum of elements
        for (int row = 0; row <= rowsInput - squareSize; row++)
        {
            for (int col = 0; col <= columsInput-squareSize; col++)
            {
                for (int i = 0; i < squareSize; i++)
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        currentSum += inputMatrix[row + i, col + j];
                    }
                }
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    maxRow = row;
                    maxCol = col;
                }
                currentSum = 0;
            }
        }

        // printing the result
        Console.WriteLine("The square 3 x 3 that has maximal sum of its elements is:");

        for (int row = maxRow; row < maxRow+squareSize; row++)
        {
            for (int col = maxCol; col < maxCol+squareSize; col++)
            {
                Console.Write(inputMatrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("and the sum of its elements is {0}", maxSum);
    }
}
