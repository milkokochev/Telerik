using System;

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.UnicodeEncoding.UTF8;

            char copyR = '\u00A9';
            Console.WriteLine("{0,5}", copyR);
            Console.WriteLine("{0,4}{0,2}", copyR);
            Console.WriteLine("{0,3}{0,4}", copyR);
            Console.WriteLine("{0,2}{0,2}{0,2}{0,2}", copyR);
        }
    }