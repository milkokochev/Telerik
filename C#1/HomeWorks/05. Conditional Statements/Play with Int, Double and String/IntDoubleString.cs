//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int \n2 --> double \n3 --> string");
        int choise = int.Parse(Console.ReadLine());


        switch (choise)
        {
            case 1:
                {
                    Console.Write("Please enter an int:");
                    int input = int.Parse(Console.ReadLine());
                    input += 1;
                    Console.WriteLine(input);
                    break;
                }
            case 2:
                {
                    Console.Write("Please enter a double:");
                    double input = double.Parse(Console.ReadLine());
                    input += 1;
                    Console.WriteLine(input);
                    break;
                }
            case 3:
                {
                    Console.Write("Please enter a string:");
                    string input = Console.ReadLine();
                    input += "*";
                    Console.WriteLine(input);
                    break;
                }

            default: Console.WriteLine("Invalid choice");
                break;
        }
    }
}