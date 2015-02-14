using System;

    class Program
    {
        static void Main()
        {
            string withQuotes = @"The ""use"" of quotations causes difficulties.";
            string withoutQuotes = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(withQuotes);
            Console.WriteLine(withoutQuotes);

        }
    }