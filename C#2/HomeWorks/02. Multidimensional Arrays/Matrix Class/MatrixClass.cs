//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, 
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Columns
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    //indexer
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    //adding
    public static Matrix operator +(Matrix first, Matrix second)
    {

        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }

    //subtracting
    public static Matrix operator -(Matrix first, Matrix second)
    {

        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    //multiplying
    public static Matrix operator *(Matrix first, Matrix second)
    {

        Matrix result = new Matrix(first.Rows, first.Columns);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] * second[row, col];
            }
        }
        return result;
    }

    //printing
    public static void Print(Matrix matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Columns; col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    //.ToString()
    public override string ToString()
    {
        string result = null;

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result += this[row, col] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }

    class MatrixClass
    {
        static void Main()
        {
            Matrix firstMatrix = new Matrix(3, 3);
            Matrix secondMatrix = new Matrix(3, 3);

            Random number = new Random();

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Columns; col++)
                {
                    firstMatrix[row, col] = number.Next(-10, 10);
                    secondMatrix[row, col] = number.Next(-10, 10);
                }
            }


            Console.WriteLine("\nFirst Matrix\n");
            Matrix.Print(firstMatrix);
            Console.WriteLine("\nSecond Matrix\n");
            Matrix.Print(secondMatrix);

            Matrix tempMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Columns);

            Console.WriteLine("\nAdding\n");
            tempMatrix = firstMatrix + secondMatrix;
            Matrix.Print(tempMatrix);

            Console.WriteLine("\nSubtracting\n");
            tempMatrix = firstMatrix - secondMatrix;
            Matrix.Print(tempMatrix);

            Console.WriteLine("\nMultiplying\n");
            tempMatrix = firstMatrix * secondMatrix;
            Matrix.Print(tempMatrix);

            Console.WriteLine("\nToString\n");
            Console.WriteLine(firstMatrix.ToString());
            

        }
    }
}