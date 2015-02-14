using System;

    class Program
    {
        static void Main()
        {
            int firstNumber=0;
            double secondNumber=0.00;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            //firstNumber += null;              //we can not add null literal to non-nullable type.         
            //secondNumber += null;             //we can not add null literal to non-nullable type.

            firstNumber += 5;
            secondNumber += 5.55;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
        }
    }