using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

namespace SineWaveTrial
{
    internal class Program
    {
        static void Normal(string str)
        {
            while (true)
            {
                double timestamp = Stopwatch.GetTimestamp();
                double seconds = timestamp / Stopwatch.Frequency;

                Console.SetCursorPosition(0, (int)Math.Round((Math.Sin(seconds) + 1) * 3));

                Console.Write(str);
            }
        }
        static void Main(string[] args)
        {
            string[,] DRAWING_GAME = new string[12, 12];

            int[,] Lengths = new int[13, 12];

            string prompt = @"                                                                                                   
▓█████▄  ██▀███   ▄▄▄       █     █░ ██▓ ███▄    █   ▄████      ▄████  ▄▄▄       ███▄ ▄███▓▓█████
▒██▀ ██▌▓██ ▒ ██▒▒████▄    ▓█░ █ ░█░▓██▒ ██ ▀█   █  ██▒ ▀█▒    ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀
░██   █▌▓██ ░▄█ ▒▒██  ▀█▄  ▒█░ █ ░█ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███  
░▓█▄   ▌▒██▀▀█▄  ░██▄▄▄▄██ ░█░ █ ░█ ░██░▓██▒  ▐▌██▒░▓█  ██▓   ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄
░▒████▓ ░██▓ ▒██▒ ▓█   ▓██▒░░██▒██▓ ░██░▒██░   ▓██░░▒▓███▀▒   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒
 ▒▒▓  ▒ ░ ▒▓ ░▒▓░ ▒▒   ▓▒█░░ ▓░▒ ▒  ░▓  ░ ▒░   ▒ ▒  ░▒   ▒     ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░
 ░ ▒  ▒   ░▒ ░ ▒░  ▒   ▒▒ ░  ▒ ░ ░   ▒ ░░ ░░   ░ ▒░  ░   ░      ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░
 ░ ░  ░   ░░   ░   ░   ▒     ░   ░   ▒ ░   ░   ░ ░ ░ ░   ░    ░ ░   ░   ░   ▒   ░      ░      ░  
   ░       ░           ░  ░    ░     ░           ░       ░          ░       ░  ░       ░      ░  ░
 ░                                                                                                
                                                                                                   
";

            int Row = 0, Column = 0;

            DRAWING_GAME[Row, Column++] = "          ";
            DRAWING_GAME[Row, Column++] = "▓█████▄";
            DRAWING_GAME[Row, Column++] = "▒██▀ ██▌";
            DRAWING_GAME[Row, Column++] = "░██   █▌";
            DRAWING_GAME[Row, Column++] = "░▓█▄   ▌";
            DRAWING_GAME[Row, Column++] = "░▒████▓ ";
            DRAWING_GAME[Row, Column++] = " ▒▒▓  ▒ ";
            DRAWING_GAME[Row, Column++] = " ░ ▒  ▒";
            DRAWING_GAME[Row, Column++] = " ░ ░  ░";
            DRAWING_GAME[Row, Column++] = "   ░";
            DRAWING_GAME[Row, Column++] = " ░";
            DRAWING_GAME[Row, Column++] = "          ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "          ";
            DRAWING_GAME[Row, Column++] = " ██▀███";
            DRAWING_GAME[Row, Column++] = "▓██ ▒ ██";
            DRAWING_GAME[Row, Column++] = "▓██ ░▄█ ";
            DRAWING_GAME[Row, Column++] = "▒██▀▀█▄ ";
            DRAWING_GAME[Row, Column++] = "░██▓ ▒██▒";
            DRAWING_GAME[Row, Column++] = "░ ▒▓ ░▒▓░";
            DRAWING_GAME[Row, Column++] = "  ░▒ ░ ▒░";
            DRAWING_GAME[Row, Column++] = "  ░░   ░ ";
            DRAWING_GAME[Row, Column++] = "   ░     ";
            DRAWING_GAME[Row, Column++] = "          ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "  ▄▄▄      ";
            DRAWING_GAME[Row, Column++] = "▒▒████▄    ";
            DRAWING_GAME[Row, Column++] = "▒▒██  ▀█▄  ";
            DRAWING_GAME[Row, Column++] = " ░██▄▄▄▄██ ";
            DRAWING_GAME[Row, Column++] = "▒ ▓█   ▓██▒";
            DRAWING_GAME[Row, Column++] = "░ ▒▒   ▓▒█░";
            DRAWING_GAME[Row, Column++] = "░  ▒   ▒▒ ░";
            DRAWING_GAME[Row, Column++] = "   ░   ▒   ";
            DRAWING_GAME[Row, Column++] = "       ░  ░";
            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = " █     █░";
            DRAWING_GAME[Row, Column++] = "▓█░ █ ░█░";
            DRAWING_GAME[Row, Column++] = "▒█░ █ ░█ ";
            DRAWING_GAME[Row, Column++] = "░█░ █ ░█ ";
            DRAWING_GAME[Row, Column++] = "░░██▒██▓ ";
            DRAWING_GAME[Row, Column++] = "░ ▓░▒ ▒  ";
            DRAWING_GAME[Row, Column++] = "  ▒ ░ ░  ";
            DRAWING_GAME[Row, Column++] = "  ░   ░  ";
            DRAWING_GAME[Row, Column++] = "    ░    ";
            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = " ██▓ ";
            DRAWING_GAME[Row, Column++] = "▓██▒ ";
            DRAWING_GAME[Row, Column++] = "▒██▒▓";
            DRAWING_GAME[Row, Column++] = "░██░▓";
            DRAWING_GAME[Row, Column++] = "░██░▒";
            DRAWING_GAME[Row, Column++] = "░▓  ░";
            DRAWING_GAME[Row, Column++] = " ▒ ░░";
            DRAWING_GAME[Row, Column++] = " ▒ ░ ";
            DRAWING_GAME[Row, Column++] = " ░  ";
            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "███▄    █ ";
            DRAWING_GAME[Row, Column++] = "██ ▀█   █ ";
            DRAWING_GAME[Row, Column++] = "██  ▀█ ██▒";
            DRAWING_GAME[Row, Column++] = "██▒  ▐▌██▒";
            DRAWING_GAME[Row, Column++] = "██░   ▓██░";
            DRAWING_GAME[Row, Column++] = " ▒░   ▒ ▒ ";
            DRAWING_GAME[Row, Column++] = " ░░   ░ ▒░";
            DRAWING_GAME[Row, Column++] = "  ░   ░ ░ ";
            DRAWING_GAME[Row, Column++] = "        ░ ";
            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "  ▄████    ";
            DRAWING_GAME[Row, Column++] = " ██▒ ▀█▒ ";
            DRAWING_GAME[Row, Column++] = "▒██░▄▄▄░  ";
            DRAWING_GAME[Row, Column++] = "░▓█  ██▓ ";
            DRAWING_GAME[Row, Column++] = "░▒▓███▀▒ ";
            DRAWING_GAME[Row, Column++] = " ░▒   ▒  ";
            DRAWING_GAME[Row, Column++] = "  ░   ░ ";
            DRAWING_GAME[Row, Column++] = "░ ░   ░ ";
            DRAWING_GAME[Row, Column++] = "      ░ ";
            DRAWING_GAME[Row, Column++] = "             ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = "  ▄████ ";
            DRAWING_GAME[Row, Column++] = " ██▒ ▀█▒";
            DRAWING_GAME[Row, Column++] = "▒██░▄▄▄░";
            DRAWING_GAME[Row, Column++] = "░▓█  ██▓";
            DRAWING_GAME[Row, Column++] = "░▒▓███▀▒";
            DRAWING_GAME[Row, Column++] = " ░▒   ▒ ";
            DRAWING_GAME[Row, Column++] = "  ░   ░ ";
            DRAWING_GAME[Row, Column++] = "░ ░   ░ ";
            DRAWING_GAME[Row, Column++] = "      ░ ";
            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = " ▄▄▄      ";
            DRAWING_GAME[Row, Column++] = "▒████▄    ";
            DRAWING_GAME[Row, Column++] = "▒██  ▀█▄  ";
            DRAWING_GAME[Row, Column++] = "░██▄▄▄▄██ ";
            DRAWING_GAME[Row, Column++] = " ▓█   ▓██▒";
            DRAWING_GAME[Row, Column++] = " ▒▒   ▓▒█░";
            DRAWING_GAME[Row, Column++] = "  ▒   ▒▒ ░";
            DRAWING_GAME[Row, Column++] = "  ░   ▒   ";
            DRAWING_GAME[Row, Column++] = "      ░  ░";
            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = " ███▄ ▄███▓";
            DRAWING_GAME[Row, Column++] = "▓██▒▀█▀ ██▒";
            DRAWING_GAME[Row, Column++] = "▓██    ▓██░";
            DRAWING_GAME[Row, Column++] = "▒██    ▒██ ";
            DRAWING_GAME[Row, Column++] = "▒██▒   ░██▒";
            DRAWING_GAME[Row, Column++] = "░ ▒░   ░  ░";
            DRAWING_GAME[Row, Column++] = "░  ░      ░";
            DRAWING_GAME[Row, Column++] = "░      ░   ";
            DRAWING_GAME[Row, Column++] = "       ░   ";
            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = "";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = "▓█████";
            DRAWING_GAME[Row, Column++] = "▓█   ▀";
            DRAWING_GAME[Row, Column++] = "▒███  ";
            DRAWING_GAME[Row, Column++] = "▒▓█  ▄";
            DRAWING_GAME[Row, Column++] = "░▒████▒";
            DRAWING_GAME[Row, Column++] = "░░ ▒░ ░";
            DRAWING_GAME[Row, Column++] = " ░ ░  ░";
            DRAWING_GAME[Row, Column++] = "   ░  ";
            DRAWING_GAME[Row, Column++] = "   ░  ░";
            DRAWING_GAME[Row, Column++] = "                  ";
            DRAWING_GAME[Row, Column++] = "";

            SetToZero(Lengths);

            void SetToZero(int[,] Length)
            {
                for (int i = 0; i < Lengths.GetLength(0); i++)
                {
                    for (int j = 0; j < Length.GetLength(1); j++)
                    {
                        Lengths[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < DRAWING_GAME.GetLength(0); i++)
            {
                for (int j = 0; j < DRAWING_GAME.GetLength(1); j++)
                {
                    Lengths[i, j] = DRAWING_GAME[i, j].Length;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.CursorVisible = false;

            //Normal(prompt);

            YOULazyFuck(Lengths);

            //AnotherTry(DRAWING_GAME, Lengths);
        }
        static void Sum(int[,] Lengths)
        {
            /*for (int i = 0; i < Lengths.GetLength(0); i++)
            {
                for (int j = 0; j < Lengths.GetLength(1); j++)
                {
                    Console.Write(Lengths[i, j] + "\t|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");*/
            for (int i = 1; i < Lengths.GetLength(0); i++)
            {
                for (int j = Lengths.GetLength(1) -1; j >= 1 ; j--)
                {
                    int Count = 0;

                    for (int T = j; T >= 1; T--)
                        Count += Lengths[i, T];

                    Lengths[i, j] = Count;
                }
            }
            /*for (int i = 0; i < Lengths.GetLength(0); i++)
            {
                for (int j = 0; j < Lengths.GetLength(1); j++)
                {
                    Console.Write(Lengths[i, j] + "\t|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");*/
        }
        static void YOULazyFuck(int[,] Lengths)
        {
            for (int i = 0; i < Lengths.GetLength(0); i++)
            {
                for (int j = 0; j < Lengths.GetLength(1); j++)
                {
                    Console.Write(Lengths[i, j] + "\t|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < Lengths.GetLength(0); i++)
            {
                for (int j = Lengths.GetLength(1) -1; j >= 0; j--)
                {
                    Console.Write(Lengths[i, j] + "\t|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
        static void FirstTry(string[] DRAWING_GAME, int[] Lengths)
        {
            int Count = 0;

            for (int i = 1; true; i++)
            {
                double timestamp = Stopwatch.GetTimestamp();
                double seconds = timestamp / Stopwatch.Frequency;

                //(int)Math.Round((Math.Sin(seconds + 0.1 * i) + 1) * 3)


                Console.SetCursorPosition(Count, i);

                Console.Write(DRAWING_GAME[i]);

                Thread.Sleep(3000);

                if (i == 11)
                    i = 1;

                Count += Lengths[i + 1];
            }
        }
        static void SecondTry(string[,] DRAWING_GAME)
        {
            for (int i = 1, j = 0; true; i++, j += 10)
            {
                double timestamp = Stopwatch.GetTimestamp();
                double seconds = timestamp / Stopwatch.Frequency;

                Console.SetCursorPosition(j, (int)Math.Round(Math.Abs(Math.Sin(seconds + 0.1 * i)) * 3));

                for (int T = 0; T < DRAWING_GAME.GetLength(1); T++)
                {
                    Console.Write(DRAWING_GAME[i, T]);
                    Console.WriteLine();
                }

                if (i == 11)
                    i = 1;
                if (j == 110)
                    j = 0;
            }
        }
        static void AnotherTry(string[,] DRAWING_GAME, int[,] Lengths)
        {
            PrintLetter(DRAWING_GAME, 0, Lengths);

            PrintLetter(DRAWING_GAME, 1, Lengths);

            PrintLetter(DRAWING_GAME, 2, Lengths);

            PrintLetter(DRAWING_GAME, 3, Lengths);

            //PrintLetter(DRAWING_GAME, 4, Lengths);

            //PrintLetter(DRAWING_GAME, 6, Lengths);

            //PrintLetter(DRAWING_GAME, 7, Lengths);

            //PrintLetter(DRAWING_GAME, 8, Lengths);

            //PrintLetter(DRAWING_GAME, 9, Lengths);

            //PrintLetter(DRAWING_GAME, 10, Lengths);

            //PrintLetter(DRAWING_GAME, 11, Lengths);

            Console.WriteLine();
        }
        static void PrintLetter(string[,] DRAWING_GAME, int Row, int[,] Lengths)
        {
            for (int i = 1; i < DRAWING_GAME.GetLength(1); i++)
            {
                double timestamp = Stopwatch.GetTimestamp();
                double seconds = timestamp / Stopwatch.Frequency;

                Console.SetCursorPosition(Lengths[Row, Row], i);
                Console.Write(DRAWING_GAME[Row,i]);
            }
        }   
    }
}
