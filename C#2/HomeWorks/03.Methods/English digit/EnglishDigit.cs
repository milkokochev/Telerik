//Write a method that returns the last digit of given integer as an English word.


using System;


class EnglishDigit
{
    static string DigitAsWord(int number)
    {
        int lastDigit = number % 10;
        string digit = null;
        switch (lastDigit)
        {
            case 1: digit = "one"; break;
            case 2: digit = "two"; break;
            case 3: digit = "three"; break;
            case 4: digit = "four"; break;
            case 5: digit = "five"; break;
            case 6: digit = "six"; break;
            case 7: digit = "seven"; break;
            case 8: digit = "eight"; break;
            case 9: digit = "nine"; break;
            case 10: digit = "zero"; break;
        };
        return digit;
    }  
    

    static void Main()
    {
        Console.Write("Enter random nomber:");
        int number = int.Parse(Console.ReadLine());

        string digit = DigitAsWord(number);
        Console.WriteLine("Last digit of the number is {0}!", digit);
    }
}