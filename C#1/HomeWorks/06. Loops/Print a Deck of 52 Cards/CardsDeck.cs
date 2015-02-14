//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

    class CardsDeck
    {
        static void Main()
        {
            for (int i = 2; i < 15; i++)
            {
                switch (i)
                {
                    case 2:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 3:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 4:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 5:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 6:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 7:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 8:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 9:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 10:
                        Console.WriteLine("{0}♣ {0}♦ {0}♥ {0}♠", i);
                        break;
                    case 11:
                        Console.WriteLine("J♣ J♦ J♥ J♠");
                        break;
                    case 12:
                        Console.WriteLine("Q♣ Q♦ Q♥ Q♠");
                        break;
                    case 13:
                        Console.WriteLine("K♣ K♦ K♥ K♠");
                        break;
                    case 14:
                        Console.WriteLine("A♣ A♦ A♥ A♠");
                        break;
                }
            }
        }
    }