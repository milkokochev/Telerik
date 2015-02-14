﻿//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
//Note: You may need to learn how to parse dates and times.

using System;

class Beer
{
    static void Main()
    {
        DateTime beerTimeStart = DateTime.Parse("01:00 PM");
        DateTime beerTimeEnd = DateTime.Parse("03:00 AM");

        Console.WriteLine("Enter time in format \"hh:mm tt\"");
        string input = Console.ReadLine();

        DateTime isBeerTime;
        bool invalidInput = DateTime.TryParse(input, out isBeerTime);

        if (invalidInput == true)
        {
            isBeerTime = DateTime.Parse(input);
            if ((isBeerTime.TimeOfDay >= beerTimeStart.TimeOfDay) || (isBeerTime.TimeOfDay < beerTimeEnd.TimeOfDay))
            {
                Console.WriteLine("beer time");
            }
            else if ((isBeerTime.TimeOfDay < beerTimeStart.TimeOfDay) || (isBeerTime.TimeOfDay >= beerTimeEnd.TimeOfDay))
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}