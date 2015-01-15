//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the matrix:");
        int matrixSize = int.Parse(Console.ReadLine());

        // matrix a)
        Console.WriteLine("\n{0}\n", new string('=', 20));
        Console.WriteLine("a)\n");
        MatrixA(matrixSize);

        // matrix b)
        Console.WriteLine("\n{0}\n", new string('=', 20));
        Console.WriteLine("b)\n");
        MatrixB(matrixSize);

        // matrix c)
        Console.WriteLine("\n{0}\n", new string('=', 20));
        Console.WriteLine("c)\n");
        MatrixC(matrixSize);

        //matrix d)
        Console.WriteLine("\n{0}\n", new string('=', 20));
        Console.WriteLine("d)\n");
        MatrixD(matrixSize);


    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void MatrixA(int matrixSize)
    {
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write("{0,-4}", row + 1 + col * matrixSize);
            }
            Console.WriteLine();
        }

    }

    static void MatrixB(int matrixSize)
    {
        int[,] matrixB = new int[matrixSize, matrixSize];
        int row = 0;
        int col = 0;
        int verticalSteps = matrixSize;

        int currentStep = 1;
        string direction = "down";

        for (int i = 1; i <= matrixSize * matrixSize; i++)
        {
            matrixB[row, col] = i;

            if (currentStep < verticalSteps)
            {
                currentStep++;
            }
            else
            {
                currentStep = 1;
                col++;
                if (direction == "up")
                {
                    direction = "down";
                    row--;
                }
                else
                {
                    direction = "up";
                    row++;
                }
            }
            switch (direction)
            {
                case "up": row--; break;
                case "down": row++; break;
            }
        }
        PrintMatrix(matrixB);
    }

    static void MatrixC(int matrixSize)
    {
        int[,] matrixC = new int[matrixSize, matrixSize];
        int row = matrixC.GetLength(0) - 1;
        int col = 0;

        for (int i = 1; i <= matrixSize * matrixSize; i++)
        {
            matrixC[row, col] = i;

            if (row == matrixC.GetLength(0) - 1 && col < matrixC.GetLength(1) - 1)
            {
                if (col == 0)
                {
                    row -= 2;
                }
                else
                {
                    row = row - col - 2;
                }
                col = -1;
            }
            if (row == matrixC.GetLength(0) - 1 && col == matrixC.GetLength(1) - 1)
            {
                row = -1;
                col = 0;
            }
            if (col == matrixC.GetLength(1) - 1 && row < matrixC.GetLength(0) - 1)
            {
                if (row == 1)
                {
                    col--;
                    row = -1;
                }
                else
                {
                    col = matrixC.GetLength(1)-row - 1;
                    row = -1;
                }
            }
            col++;
            row++;

            if (col > matrixC.GetLength(1) - 1)
            {
                row--;
            }
        }
        PrintMatrix(matrixC);
    }

    static void MatrixD(int matrixSize)
    {
        int[,] matrixD = new int[matrixSize, matrixSize];
        int col = 0;
        int row = 0;
        int direction = 0;          // 0 = right; 1= down; 2= left; = 3 = up
        int stepsPerformed = 0;     //counts how many elements from the matrix is printed in the current direction
        int stepsToMake = matrixSize - 1;  // how many steps must perform in the current direction
        int stepChange = -1;        // first reduction of "stepsToMake" is after 3 direction changes, after that is every 2 changes 

        for (int i = 1; i <= matrixSize * matrixSize; i++)
        {
            matrixD[row, col] = i;

            if (stepsPerformed < stepsToMake)
            {
                stepsPerformed++;
            }
            else
            {
                stepsPerformed = 1;
                if (stepChange == 1)
                {
                    stepsToMake--;
                }
                stepChange = (stepChange + 1) % 2;
                direction = (direction + 1) % 4;
            }
            switch (direction)
            {
                case 0: row++; break;
                case 1: col++; break;
                case 2: row--; break;
                case 3: col--; break;
            }
        }
        PrintMatrix(matrixD);

    }
}
