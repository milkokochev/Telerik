﻿using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            if ((i % 2 == 0) & (i != 12))
            {
                Console.Write(i + ", ");
            }
            else if (i == 11)
            {
                Console.WriteLine(-i);
            }
            else
            {
                Console.Write(-i + ", ");
            }
        }
    }
}