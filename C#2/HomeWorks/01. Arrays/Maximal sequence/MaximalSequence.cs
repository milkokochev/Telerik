//Write a program that finds the maximal sequence of equal elements in an array


using System;

class MaximalSequence
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        string current = input[0];
        int count = 0;
        int sequenceLenght = 0;
        string sequenceElement = null;

        for (int i = 0; i < input.Length; i++)
        {
            for (; i < input.Length; i++)
            {
                if (current == input[i])
                {
                    count++;
                }
                else
                {
                    if (sequenceLenght < count)
                    {
                        sequenceLenght = count;
                        sequenceElement = current;
                    }
                    current = input[i];
                    count = 0;
                    i--;
                }
            }
        }
        if (sequenceLenght < count)
        {
            sequenceLenght = count;
            sequenceElement = current;
        }

        for (int i = 0; i < sequenceLenght; i++)
        {
            if (i == sequenceLenght - 1)
            {
                Console.WriteLine("{0}", sequenceElement);
            }
            else
            {
                Console.Write("{0},", sequenceElement);
            }
        }
    }
}