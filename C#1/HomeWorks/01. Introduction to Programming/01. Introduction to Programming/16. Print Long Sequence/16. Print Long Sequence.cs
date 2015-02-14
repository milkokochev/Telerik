using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            if ((i % 2 == 0) & (i != 1002))
            {
                Console.Write(i + ", ");
            }
            else if (i == 1001)
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