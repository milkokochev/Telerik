//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of 
//several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.


using System;

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("How many rows will have the matrix? :");
        int rowsInput = int.Parse(Console.ReadLine());
        Console.Write("How many colums will have the matrix? :");
        int columsInput = int.Parse(Console.ReadLine());

        string[,] inputMatrix = new string[rowsInput, columsInput];

        Console.WriteLine("Enter elements of the matrix:");

        for (int row = 0; row < rowsInput; row++)
        {
            for (int col = 0; col < columsInput; col++)
            {
                Console.Write("Element [{0},{1}]:", row, col);
                inputMatrix[row, col] = Console.ReadLine();
            }
        }

        int currentCount = 0;
        int maxCounter = int.MinValue;
        string maxElement = "";

        for (int row = 0; row < rowsInput; row++)
        {
            for (int col = 0; col < columsInput; col++)
            {
                for (int i = 0; i < rowsInput; i++)
                {
                    for (int j = 0; j < columsInput; j++)
                    {
                        if (inputMatrix[i, j] == inputMatrix[row, col]
                            && (i == row || j == col
                            || (i - j) == (row - col) 
                            || (i + j) == (row + col)))
                        {
                            currentCount++;
                        }
                    }
                }
                if (currentCount>maxCounter)
                {
                    maxCounter = currentCount;
                    maxElement = inputMatrix[row, col];
                }
                currentCount = 0;

            }
        }
        Console.WriteLine("The longest sequence of equal strings is {0} of element \"{1}\"", maxCounter,maxElement);

    }
}