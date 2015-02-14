using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter Your birth date in format DD.MM.YYYY:");
        DateTime bitrthDay = DateTime.Parse(Console.ReadLine());
        DateTime futureDay = DateTime.Today.AddYears(10);
        int age = futureDay.Year - bitrthDay.Year;
        if (futureDay.Month < bitrthDay.Month || ((futureDay.Month == bitrthDay.Month) && (futureDay.Day < bitrthDay.Day)))
        {
            age--;
        }
        Console.WriteLine("Your age after ten years will be:" + age);
    }
}