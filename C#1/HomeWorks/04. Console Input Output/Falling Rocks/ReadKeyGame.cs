//Implement the "Falling Rocks" game in the text console.
//A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
//A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
//Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O).
//Ensure a constant game speed by Thread.Sleep(150).
//Implement collision detection and scoring system.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

struct Objects
{
    public int x;
    public int y;
    public string c;
    public ConsoleColor color;
}
class ReadKeyGame
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }


    static void Main()
    {
        int playfieldWidth = 20;
        int livesCount = 5;
        int maxLives = 5;
        double speed = 0;
        double maxSpeed = 400;
        int score = 0;

        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 60;


        string rocksShapes = "^@*&+%$#!.;-";


        Objects dwarf = new Objects();
        dwarf.x = 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = "(0)";
        dwarf.color = ConsoleColor.Green;
        Random randomGenerator = new Random();

        List<Objects> rocks = new List<Objects>();

        while (true)
        {

            bool carHit = false;
            {

                for (int i = 0; i < 2; i++)
                {
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 5)
                    {
                        Objects dwarfLife = new Objects();
                        dwarfLife.x = randomGenerator.Next(0, playfieldWidth - 2);
                        dwarfLife.y = 0;
                        dwarfLife.c = "♥";
                        dwarfLife.color = ConsoleColor.Red;
                        rocks.Add(dwarfLife);
                    }
                    else if (chance < 40)
                    {

                    }

                    else
                    {
                        Objects newRock = new Objects();
                        newRock.color = (ConsoleColor)randomGenerator.Next(1, 16); // 0 color is BLACK so we don`t use it
                        newRock.x = randomGenerator.Next(0, playfieldWidth);
                        newRock.y = 0;
                        newRock.c = rocksShapes[randomGenerator.Next(0, rocksShapes.Length)].ToString();
                        rocks.Add(newRock);
                    }
                }
            }
            //Move the car
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //while (Console.KeyAvailable)
                //{
                //    Console.ReadKey(true);
                //}
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 3 < playfieldWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }
            //Move cars
            List<Objects> newList = new List<Objects>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Objects oldCar = rocks[i];
                Objects newRock = new Objects();
                newRock.x = oldCar.x;
                newRock.y = oldCar.y + 1;
                newRock.c = oldCar.c;
                newRock.color = oldCar.color;
                // Check for impact
                if (newRock.c == "♥" && newRock.y == dwarf.y && (newRock.x == dwarf.x || newRock.x == dwarf.x + 1 || newRock.x == dwarf.x + 2))
                {
                    livesCount++;
                    score += 50;
                    if (livesCount > maxLives)
                    {
                        livesCount = maxLives;
                    }
                }
                if (newRock.c != "♥" && newRock.y == dwarf.y && (newRock.x == dwarf.x || newRock.x == dwarf.x + 1 || newRock.x == dwarf.x + 2))
                {
                    livesCount--;
                    carHit = true;
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(28, 7, "GAME OVER!", ConsoleColor.DarkRed);
                        //PrintStringOnPosition(8, 10, "Pres any key!", ConsoleColor.DarkRed);
                        //Console.ReadLine();
                        Console.WriteLine();
                        Environment.Exit(0);
                    }
                }
                if (newRock.y < Console.BufferHeight)
                {
                    newList.Add(newRock);
                }
                if (newRock.y == Console.BufferHeight)
                {
                    score++;
                }
            }
            rocks = newList;

            //Clear the console
            Console.Clear();
            //Redraw playfield
            if (carHit)
            {
                rocks.Clear();
                PrintOnPosition(dwarf.x + 1, dwarf.y, "X", ConsoleColor.DarkRed);
                //Console.Beep();
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
            }
            foreach (Objects car in rocks)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }
            //Draw info
            for (int i = 0; i < Console.BufferHeight; i++)
            {
                PrintStringOnPosition(playfieldWidth, i, "|", ConsoleColor.DarkGreen);

            }

            PrintStringOnPosition(playfieldWidth + 5, 4, "LIVES: " + livesCount, ConsoleColor.DarkRed);
            PrintStringOnPosition(playfieldWidth + 5, 5, "SPEED: " + (int)speed, ConsoleColor.DarkRed);
            PrintStringOnPosition(playfieldWidth + 5, 6, "SCORE: " + score, ConsoleColor.DarkRed);
            PrintStringOnPosition(playfieldWidth + 5, 10, "Colect ♥ to recover LIVES", ConsoleColor.DarkRed);
            PrintStringOnPosition(playfieldWidth + 5, 11, "and bonus SCORE ☺", ConsoleColor.DarkRed);

            //Slow down program
            Thread.Sleep((int)(400 - speed));
            if (score % 20 == 0 && score != 0)
            {
                speed += 10;
                if (speed > maxSpeed)
                {
                    speed = maxSpeed;
                }
            }

        }
    }
}