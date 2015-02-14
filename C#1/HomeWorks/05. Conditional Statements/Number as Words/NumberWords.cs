//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberWords
{
    static void Main()
    {
        string[] resultString = new string[5];
        int input = int.Parse(Console.ReadLine());
        string inputString = null;

        if ((input >= 0) && (input <= 20))
        {
            switch (input)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;
            }
        }
        else if ((input > 20) && (input < 100))
        {
            inputString = Convert.ToString(input);
            switch (inputString[0])
            {
                case '2':
                    resultString[0] = "Twenty";
                    break;
                case '3':
                    resultString[0] = "Thirty";
                    break;
                case '4':
                    resultString[0] = "Forty";
                    break;
                case '5':
                    resultString[0] = "Fifty";
                    break;
                case '6':
                    resultString[0] = "Sixty";
                    break;
                case '7':
                    resultString[0] = "Seventy";
                    break;
                case '8':
                    resultString[0] = "Eighty";
                    break;
                case '9':
                    resultString[0] = "Ninety";
                    break;
            }
            switch (inputString[1])
            {
                case '0':
                    resultString[1] = null;
                    break;
                case '1':
                    resultString[1] = "one";
                    break;
                case '2':
                    resultString[1] = "two";
                    break;
                case '3':
                    resultString[1] = "three";
                    break;
                case '4':
                    resultString[1] = "four";
                    break;
                case '5':
                    resultString[1] = "five";
                    break;
                case '6':
                    resultString[1] = "six";
                    break;
                case '7':
                    resultString[1] = "seven";
                    break;
                case '8':
                    resultString[1] = "eight";
                    break;
                case '9':
                    resultString[1] = "nine";
                    break;
            }
            Console.WriteLine("{0} {1}", resultString[0], resultString[1]);
        }
        else if ((input >= 100) && (input < 1000))
        {
            inputString = Convert.ToString(input);
            switch (inputString[0])
            {
                case '1':
                    resultString[0] = "One hundred";
                    break;
                case '2':
                    resultString[0] = "Two hundred";
                    break;
                case '3':
                    resultString[0] = "Three hundred";
                    break;
                case '4':
                    resultString[0] = "Four hundred";
                    break;
                case '5':
                    resultString[0] = "Five hundred";
                    break;
                case '6':
                    resultString[0] = "Six hundred";
                    break;
                case '7':
                    resultString[0] = "Seven hundred";
                    break;
                case '8':
                    resultString[0] = "Eight hundred";
                    break;
                case '9':
                    resultString[0] = "Nine hundred";
                    break;
            }
            if (inputString[1] == '1')
            {
                switch (inputString[2])
                {
                    case '0':
                        resultString[1] = "and ten";
                        break;
                    case '1':
                        resultString[1] = "and eleven";
                        break;
                    case '2':
                        resultString[1] = "and twelve";
                        break;
                    case '3':
                        resultString[1] = "and thirteen";
                        break;
                    case '4':
                        resultString[1] = "and fourteen";
                        break;
                    case '5':
                        resultString[1] = "and fifteen";
                        break;
                    case '6':
                        resultString[1] = "and sixteen";
                        break;
                    case '7':
                        resultString[1] = "and seventeen";
                        break;
                    case '8':
                        resultString[1] = "and eighteen";
                        break;
                    case '9':
                        resultString[1] = "and nineteen";
                        break;
                }
            }
            else
            {
                switch (inputString[1])
                {
                    case '0':
                        resultString[1] = null;
                        break;
                    case '2':
                        resultString[1] = "and twenty";
                        break;
                    case '3':
                        resultString[1] = "and thirty";
                        break;
                    case '4':
                        resultString[1] = "and forty";
                        break;
                    case '5':
                        resultString[1] = "and fifty";
                        break;
                    case '6':
                        resultString[1] = "and sixty";
                        break;
                    case '7':
                        resultString[1] = "and seventy";
                        break;
                    case '8':
                        resultString[1] = "and eighty";
                        break;
                    case '9':
                        resultString[1] = "and ninety";
                        break;
                }
                switch (inputString[2])
                {
                    case '0':
                        resultString[2] = null;
                        break;
                    case '1':
                        resultString[2] = "one";
                        break;
                    case '2':
                        resultString[2] = "two";
                        break;
                    case '3':
                        resultString[2] = "three";
                        break;
                    case '4':
                        resultString[2] = "four";
                        break;
                    case '5':
                        resultString[2] = "five";
                        break;
                    case '6':
                        resultString[2] = "six";
                        break;
                    case '7':
                        resultString[2] = "seven";
                        break;
                    case '8':
                        resultString[2] = "eight";
                        break;
                    case '9':
                        resultString[2] = "nine";
                        break;
                }
            }
            Console.WriteLine("{0} {1} {2}", resultString[0], resultString[1], resultString[2]);
        }
        else
        {
            Console.WriteLine("Input is out of range (0-999) or not a digit!");
        }
    }
}