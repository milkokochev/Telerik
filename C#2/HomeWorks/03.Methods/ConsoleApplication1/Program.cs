using System;
using System.Collections.Generic;
using System.Linq;

class FindSequenceInMatrix
{
    public static List<int> bestLength = new List<int>();
    public static List<string> bestElement = new List<string>();

    static string[,] FillMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        return matrix;
    }

    static void CheckCols(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = string.Empty;
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            currentElement = matrix[0, col];

            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (currentElement == matrix[row + 1, col])
                {
                    counter++;
                    row++;

                    if (counter > maxCounter && counter == matrix.GetLength(0))
                    {
                        maxCounter = counter;
                        element = currentElement;
                        counter = 1;
                    }
                }
                else
                {
                    counter = 1;
                    break;
                }
            }
            row = 0;
            col++;
        }

        Console.WriteLine(maxCounter);
        Console.WriteLine(element);
        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckRows(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = string.Empty;
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            currentElement = matrix[row, 0];

            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (currentElement == matrix[row, col + 1])
                {
                    counter++;
                    col++;

                    if (counter > maxCounter && counter == matrix.GetLength(1))
                    {
                        maxCounter = counter;
                        element = currentElement;
                        counter = 1;
                    }
                }
                else
                {
                    counter = 1;
                    break;
                }
            }
            col = 0;
            row++;
        }
        Console.WriteLine(maxCounter);
        Console.WriteLine(element);
        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }

    static void CheckUnderMainDiagonal(string[,] matrix)
    {
        int counter = 1;
        int maxCounter = 0;
        string element = string.Empty;
        string currentElement = string.Empty;

        int row = 0;
        int col = 0;

        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            row = i;
            currentElement = matrix[row, 0];

            while (row < matrix.GetLength(0))
            {
                if (currentElement == matrix[++row, ++col])
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        element = currentElement;
                        counter = 1;
                    }
                }
                else
                {
                    counter = 1;
                    maxCounter = 0;
                    element = string.Empty;
                    break;
                }
            }
            col = 0;

        }
        Console.WriteLine(maxCounter);
        Console.WriteLine(element);
        bestLength.Add(maxCounter);
        bestElement.Add(element);
    }
    static void Main()
    {
        //Console.Write("Please enter the number of rows in your matrix: ");
        //int rows = Int32.Parse(Console.ReadLine());

        //Console.Write("Please enter the numbers of columns in your matrix: ");
        //int cols = Int32.Parse(Console.ReadLine());

        string[,] matrix = {
                           {"a", "rr", "rru", "r"},
                           {"ww", "a", "rru", "r"},
                           {"k", "ow", "a", "r"},
                           {"rru", "k", "to", "a"}};//new string[rows, cols];
        //CheckCols(matrix);
        //CheckRows(matrix);
        CheckUnderMainDiagonal(matrix);
        //Console.Write("Sequence: ");
        //FillMatrix(matrix);

        //CheckForSequenceInMatrix(matrix, ref bestCounter, ref currentElement);
    }
}