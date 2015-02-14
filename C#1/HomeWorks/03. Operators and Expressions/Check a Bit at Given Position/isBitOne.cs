//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;

    class isBitOne
    {
        static void Main()
        {
            Console.Write("Enter number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position of the Bit:");
            int position = int.Parse(Console.ReadLine());
            
            number = number >> position;
            number = number & 1;
            if (number==1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }