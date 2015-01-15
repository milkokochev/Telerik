//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.


using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(65 + i);
        }

        string input = Console.ReadLine().ToUpper();

        foreach (char simbol in input)
        {
            int first = 0;
            int last = alphabet.Length - 1;
            int mid = 0;


            while (first <= last)
            {
                mid = last + first / 2 - last / 2;

                if (simbol == alphabet[mid])
                {
                    Console.WriteLine(" The char \"{0}\" has index {1} of the alphabet array!", simbol, mid);
                    first = last + 1;
                }

                else if (simbol < alphabet[mid])
                {
                    last = mid - 1;
                }

                else
                {
                    first = mid + 1;
                }
            }
        }
    }
}