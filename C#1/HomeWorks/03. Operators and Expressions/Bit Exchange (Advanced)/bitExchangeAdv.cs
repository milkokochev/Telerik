//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class bitExchangeAdv
{
    static void Main()
    {
        uint number;
        Console.Write("Enter number:");
        uint.TryParse(Console.ReadLine(), out number);

        Console.Write("Enter first position:");
        int firstBit = int.Parse(Console.ReadLine());

        Console.Write("Enter second position:");
        int secondBit = int.Parse(Console.ReadLine());

        Console.Write("Enter the range of the sequence:");
        int sequence = int.Parse(Console.ReadLine());

        int tempBitsP = 1;
        int tempBitsK = 1;

        for (int i = 0; i < sequence; i++)
        {
            tempBitsP |= (1 << i);
            tempBitsK |= (1 << i);
        }

        tempBitsP = (tempBitsP << firstBit);
        tempBitsK = (tempBitsK << secondBit);

        if ((firstBit + sequence) > 31 || (secondBit + sequence) > 31)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Abs(firstBit - secondBit) < sequence)
        {
            Console.WriteLine("overlapping");
        }
        else if (firstBit < secondBit)
        {
            Console.WriteLine((number ^ (number & tempBitsP | number & tempBitsK)) | ((number & tempBitsK) >> Math.Abs(secondBit - firstBit)) | ((number & tempBitsP) << Math.Abs(secondBit - firstBit)));
        }
        else
        {
            Console.WriteLine((number ^ (number & tempBitsP | number & tempBitsK)) | ((number & tempBitsK) << Math.Abs(secondBit - firstBit)) | ((number & tempBitsP) >> Math.Abs(secondBit - firstBit)));
        }
    }
}