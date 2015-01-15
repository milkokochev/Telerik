using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ClassMatrix
{
    class Matrix
    {
        /*Write a class Matrix, to holds a matrix of integers. 
         * Overload the operators for adding, subtracting and 
         * multiplying of matrices, indexer for accessing the 
         * matrix content and ToString().*/

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
        public static void Print(Matrix matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }


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

        public override string ToString()
        {
            string result = null;
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                {
                    result += matrix[row, col] + " ";
                }
                result += Environment.NewLine;
            }
            return result;
        }
    }

    class ClassMatrix
    {
        static void Main()
        {
            Matrix matrixFirst = new Matrix(3, 3);
            Matrix matrixSecond = new Matrix(3, 3);

            // filling the matrices
            Random numbers = new Random();
            for (int row = 0; row < matrixFirst.Rows; row++)
            {
                for (int col = 0; col < matrixFirst.Columns; col++)
                {
                    matrixFirst[row, col] = numbers.Next(-10,10);
                    matrixSecond[row, col] = numbers.Next(-10,10);
                }
            }
            Console.WriteLine("First matrix:");
            Matrix.Print(matrixFirst);
            Console.WriteLine();
            Console.WriteLine("Second matrix:");
            Matrix.Print(matrixSecond);
            Console.WriteLine();

            Matrix sum = matrixFirst + matrixSecond;
            Matrix substract = matrixFirst - matrixSecond;
            Matrix multiple = matrixFirst * matrixSecond;

            Console.WriteLine("Adding:");
            Console.WriteLine(sum.ToString());
            Console.WriteLine("Substracting:");
            Console.WriteLine(substract.ToString());
            Console.WriteLine("Multiplying:");
            Console.WriteLine(matrixFirst.ToString());
        }
    }
}
