//Write a program that reads from the console a positive integer number n (1 = n = 20) 
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.

using System;

class Matrix
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int[,] matrix = new int[input, input];
        int col = 0;
        int row = 0;
        int direction = 0;          // 0 = right; 1= down; 2= left; = 3 = up
        int stepsPerformed = 0;     //counts how many elements from the matrix is printed in the current direction
        int stepsToMake = input - 1;  // how many steps must perform in the current direction
        int stepChange = -1;        // first reduction of "stepsToMake" is after 3 direction changes, after that is every 2 changes 

        for (int i = 1; i <= input * input; i++)
        {
            matrix[row, col] = i;

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
                case 0: col++; break;
                case 1: row++; break;
                case 2: col--; break;
                case 3: row--; break;
            }
        }
        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}