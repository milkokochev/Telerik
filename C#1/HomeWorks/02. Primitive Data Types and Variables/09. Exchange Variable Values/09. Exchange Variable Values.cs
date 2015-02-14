using System;

    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before exchange:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after exchange:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }