using System;
using System.Text;

class SolveTasks
{

    static int inputNumOrLength;
    static int[] arrayNumbers;
    static double averageSum;
    static double coeffA;
    static double coeffB;
    static int inputInfo = InputData();

    static void VerifyingInputNumber() // input number for 1 or lenght for 2
    {
        while (true)
        {
            Console.Write("\t Please enter positive integer: ");
            if (int.TryParse(Console.ReadLine(), out inputNumOrLength) && inputNumOrLength > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\t\t Invalid value! Try again!");
            }
        }
    }

    static void VerifyingSequense(int inputNumOrLength) // if it is empty
    {
        arrayNumbers = new int[inputNumOrLength];
        Console.WriteLine("\t Please enter elements of sequense: ");
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            while (true)
            {
                Console.Write("\t\t array[{0}] = ", i);
                if (int.TryParse(Console.ReadLine(), out arrayNumbers[i]))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\t\t Invalid value! Try again!");
                }
            }
        }
    }

    static void VerifingCoeff()
    {
        while (true)
        {
            Console.Write("\t Please enter number 'a' NOT equale to 0: ");
            if (double.TryParse(Console.ReadLine(), out coeffA) && coeffA != 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\t\t Invalid value! Try again!");
            }
        }
        while (true)
        {
            Console.Write("\t Please enter 'b': ");
            if (double.TryParse(Console.ReadLine(), out coeffB))
            {
                break;
            }
            else
            {
                Console.WriteLine("\t\t Invalid value! Try again!");
            }
        }
    }

    static string ReverseDigits(int inputNumOrLength)
    {
        string result = inputNumOrLength.ToString();


        if (result.Length == 1 && (Convert.ToChar(result) - '0' >= 0 && Convert.ToChar(result) - '0' <= 0))
        {
            return result;
        }
        else
        {
            char[] numberChar = Convert.ToString(inputNumOrLength).ToCharArray();
            Array.Reverse(numberChar);
            StringBuilder resultNumber = new StringBuilder();
            result = Convert.ToString(resultNumber.Append(numberChar));
            while (result[0] == '0')
            {
                result = result.Substring(1, result.Length - 1);
            }
            return result;
        }
    }

    static double CalcAverage()
    {
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            averageSum += arrayNumbers[i];
        }
        averageSum /= arrayNumbers.Length;
        return averageSum;
    }

    static void SolvingEquation()
    {
        Console.WriteLine("\t The solution is:");
        Console.WriteLine("\t\t x = {0:0.00}", -coeffB / coeffA);
    }

    static void Print()
    {
        if (inputInfo == 2)
        {
            Console.WriteLine("\t The given sequence is:");
            Console.Write("\t\t ");
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write(arrayNumbers[i] + " ");
            }
        }
        else if (inputInfo == 3)
        {
            Console.WriteLine("\t The given equation is:");
            Console.WriteLine("\t\t {0} * x + {1} = 0", coeffA, coeffB);
        }
        Console.WriteLine();
    }


    static int InputData() //1 or 2 or 3
    {
        int inputData;
        while (true)
        {
            Console.WriteLine("Please choose: \n\t 1 - Reversing digits of a number. \n\t 2 - Calculates the average of a sequence. \n\t 3 - Solving a * x + b = 0");
            Console.WriteLine(new string('-', 20));
            Console.Write("Your choice is: ");

            if (int.TryParse(Console.ReadLine(), out inputData) && (inputData == 1 || inputData == 2 || inputData == 3))
            {
                return inputData;
            }
            else
            {
                Console.WriteLine("\t\t Invalid value! Try again!");
            }
        }
    }

    static void Main()
    {
        if (inputInfo == 1)
        {
            Console.WriteLine("Number To Be Reversed :");
            VerifyingInputNumber();
            Console.WriteLine("\t {0} -> {1}", inputNumOrLength, ReverseDigits(inputNumOrLength));
        }
        else if (inputInfo == 2)
        {
            Console.WriteLine("Length of Sequense :");
            VerifyingInputNumber();
            VerifyingSequense(inputNumOrLength);
            Print();
            Console.WriteLine("\t The averege sum is {0:0.00}.", CalcAverage());
        }
        else if (inputInfo == 3)
        {
            VerifingCoeff();
            Print();
            SolvingEquation();
        }
    }
}