using System;
using System.Diagnostics;
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
            string[,] DRAWING_GAME = new string[11, 12];

            int[,] Lengths = new int[12, 12];

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

            DRAWING_GAME[Row, Column++] = "        ";
            DRAWING_GAME[Row, Column++] = "▓█████▄ ";
            DRAWING_GAME[Row, Column++] = "▒██▀ ██▌";
            DRAWING_GAME[Row, Column++] = "░██   █▌";
            DRAWING_GAME[Row, Column++] = "░▓█▄   ▌";
            DRAWING_GAME[Row, Column++] = "░▒████▓ ";
            DRAWING_GAME[Row, Column++] = " ▒▒▓  ▒ ";
            DRAWING_GAME[Row, Column++] = " ░ ▒  ▒ ";
            DRAWING_GAME[Row, Column++] = " ░ ░  ░ ";
            DRAWING_GAME[Row, Column++] = "   ░    ";
            DRAWING_GAME[Row, Column++] = " ░      ";
            DRAWING_GAME[Row, Column++] = "        ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "         ";
            DRAWING_GAME[Row, Column++] = " ██▀███  ";
            DRAWING_GAME[Row, Column++] = "▓██ ▒ ██ ";
            DRAWING_GAME[Row, Column++] = "▓██ ░▄█  ";
            DRAWING_GAME[Row, Column++] = "▒██▀▀█▄  ";
            DRAWING_GAME[Row, Column++] = "░██▓ ▒██▒";
            DRAWING_GAME[Row, Column++] = "░ ▒▓ ░▒▓░";
            DRAWING_GAME[Row, Column++] = "  ░▒ ░ ▒░";
            DRAWING_GAME[Row, Column++] = "  ░░   ░ ";
            DRAWING_GAME[Row, Column++] = "   ░     ";
            DRAWING_GAME[Row, Column++] = "         ";
            DRAWING_GAME[Row, Column++] = "         ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = "  ▄▄▄      ";
            DRAWING_GAME[Row, Column++] = "▒▒████▄    ";
            DRAWING_GAME[Row, Column++] = "▒▒██  ▀█▄  ";
            DRAWING_GAME[Row, Column++] = " ░██▄▄▄▄██ ";
            DRAWING_GAME[Row, Column++] = "▒ ▓█   ▓██▒";
            DRAWING_GAME[Row, Column++] = "░ ▒▒   ▓▒█░";
            DRAWING_GAME[Row, Column++] = "░  ▒   ▒▒ ░";
            DRAWING_GAME[Row, Column++] = "   ░   ▒   ";
            DRAWING_GAME[Row, Column++] = "       ░  ░";
            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = "           ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "         ";
            DRAWING_GAME[Row, Column++] = " █     █░";
            DRAWING_GAME[Row, Column++] = "▓█░ █ ░█░";
            DRAWING_GAME[Row, Column++] = "▒█░ █ ░█ ";
            DRAWING_GAME[Row, Column++] = "░█░ █ ░█ ";
            DRAWING_GAME[Row, Column++] = "░░██▒██▓ ";
            DRAWING_GAME[Row, Column++] = "░ ▓░▒ ▒  ";
            DRAWING_GAME[Row, Column++] = "  ▒ ░ ░  ";
            DRAWING_GAME[Row, Column++] = "  ░   ░  ";
            DRAWING_GAME[Row, Column++] = "    ░    ";
            DRAWING_GAME[Row, Column++] = "         ";
            DRAWING_GAME[Row, Column++] = "         ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "    ";
            DRAWING_GAME[Row, Column++] = " ██▓";
            DRAWING_GAME[Row, Column++] = "▓██▒";
            DRAWING_GAME[Row, Column++] = "▒██▒";
            DRAWING_GAME[Row, Column++] = "░██░";
            DRAWING_GAME[Row, Column++] = "░██░";
            DRAWING_GAME[Row, Column++] = "░▓  ";
            DRAWING_GAME[Row, Column++] = " ▒ ░";
            DRAWING_GAME[Row, Column++] = " ▒ ░";
            DRAWING_GAME[Row, Column++] = " ░  ";
            DRAWING_GAME[Row, Column++] = "    ";
            DRAWING_GAME[Row, Column++] = "    ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = " ███▄    █ ";
            DRAWING_GAME[Row, Column++] = " ██ ▀█   █ ";
            DRAWING_GAME[Row, Column++] = "▓██  ▀█ ██▒";
            DRAWING_GAME[Row, Column++] = "▓██▒  ▐▌██▒";
            DRAWING_GAME[Row, Column++] = "▒██░   ▓██░";
            DRAWING_GAME[Row, Column++] = "░ ▒░   ▒ ▒ ";
            DRAWING_GAME[Row, Column++] = "░ ░░   ░ ▒░";
            DRAWING_GAME[Row, Column++] = "   ░   ░ ░ ";
            DRAWING_GAME[Row, Column++] = "         ░ ";
            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = "           ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "        ";
            DRAWING_GAME[Row, Column++] = "  ▄████ ";
            DRAWING_GAME[Row, Column++] = " ██▒ ▀█▒";
            DRAWING_GAME[Row, Column++] = "▒██░▄▄▄░";
            DRAWING_GAME[Row, Column++] = "░▓█  ██▓";
            DRAWING_GAME[Row, Column++] = "░▒▓███▀▒";
            DRAWING_GAME[Row, Column++] = " ░▒   ▒ ";
            DRAWING_GAME[Row, Column++] = "  ░   ░ ";
            DRAWING_GAME[Row, Column++] = "░ ░   ░ ";
            DRAWING_GAME[Row, Column++] = "      ░ ";
            DRAWING_GAME[Row, Column++] = "        ";
            DRAWING_GAME[Row, Column++] = "        ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = "     ▄████ ";
            DRAWING_GAME[Row, Column++] = "    ██▒ ▀█▒";
            DRAWING_GAME[Row, Column++] = "   ▒██░▄▄▄░";
            DRAWING_GAME[Row, Column++] = "   ░▓█  ██▓";
            DRAWING_GAME[Row, Column++] = "   ░▒▓███▀▒";
            DRAWING_GAME[Row, Column++] = "    ░▒   ▒ ";
            DRAWING_GAME[Row, Column++] = "     ░   ░ ";
            DRAWING_GAME[Row, Column++] = "   ░ ░   ░ ";
            DRAWING_GAME[Row, Column++] = "         ░ ";
            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = "           ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "          ";
            DRAWING_GAME[Row, Column++] = " ▄▄▄      ";
            DRAWING_GAME[Row, Column++] = "▒████▄    ";
            DRAWING_GAME[Row, Column++] = "▒██  ▀█▄  ";
            DRAWING_GAME[Row, Column++] = "░██▄▄▄▄██ ";
            DRAWING_GAME[Row, Column++] = " ▓█   ▓██▒";
            DRAWING_GAME[Row, Column++] = " ▒▒   ▓▒█░";
            DRAWING_GAME[Row, Column++] = "  ▒   ▒▒ ░";
            DRAWING_GAME[Row, Column++] = "  ░   ▒   ";
            DRAWING_GAME[Row, Column++] = "      ░  ░";
            DRAWING_GAME[Row, Column++] = "          ";
            DRAWING_GAME[Row, Column++] = "          ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = " ███▄ ▄███▓";
            DRAWING_GAME[Row, Column++] = "▓██▒▀█▀ ██▒";
            DRAWING_GAME[Row, Column++] = "▓██    ▓██░";
            DRAWING_GAME[Row, Column++] = "▒██    ▒██ ";
            DRAWING_GAME[Row, Column++] = "▒██▒   ░██▒";
            DRAWING_GAME[Row, Column++] = "░ ▒░   ░  ░";
            DRAWING_GAME[Row, Column++] = "░  ░      ░";
            DRAWING_GAME[Row, Column++] = "░      ░   ";
            DRAWING_GAME[Row, Column++] = "       ░   ";
            DRAWING_GAME[Row, Column++] = "           ";
            DRAWING_GAME[Row, Column++] = "           ";

            Row++; Column = 0;

            DRAWING_GAME[Row, Column++] = "       ";
            DRAWING_GAME[Row, Column++] = "▓█████ ";
            DRAWING_GAME[Row, Column++] = "▓█   ▀ ";
            DRAWING_GAME[Row, Column++] = "▒███   ";
            DRAWING_GAME[Row, Column++] = "▒▓█  ▄ ";
            DRAWING_GAME[Row, Column++] = "░▒████▒";
            DRAWING_GAME[Row, Column++] = "░░ ▒░ ░";
            DRAWING_GAME[Row, Column++] = " ░ ░  ░";
            DRAWING_GAME[Row, Column++] = "   ░   ";
            DRAWING_GAME[Row, Column++] = "   ░  ░";
            DRAWING_GAME[Row, Column++] = "       ";
            DRAWING_GAME[Row, Column++] = "       ";

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
                    Lengths[i + 1, j] = DRAWING_GAME[i, j].Length;
                }
            }

            Sum(Lengths);

            //PrintArray(Lengths);

            Console.Write("\n");

            Console.WriteLine("\n\n");

            //PrintArray(Lengths);

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.CursorVisible = false;

            //Normal(prompt);

            LetMeHaveAGo(DRAWING_GAME, Lengths);
        }
        static void PrintArray(int[,] Lengths)
        {
            for (int i = 0; i < Lengths.GetLength(0); i++)
            {
                for (int j = 0; j < Lengths.GetLength(1); j++)
                {
                    Console.Write(Lengths[i, j] + "\t|");
                }
                Console.WriteLine();
            }
        }
        static void Sum(int[,] Lengths)
        {
            for (int i = 0; i < Lengths.GetLength(1); i++)
            {
                for (int j = Lengths.GetLength(0) - 1; j > 0; j--)
                {
                    int Count = 0;

                    for (int T = j; T > 0; T--)
                    {
                        Count += Lengths[T, i];
                    }
                    Lengths[j, i] = Count;
                }
            }
        }
        static void PrintLetter(string[,] DRAWING_GAME, int Row, int[,] Lengths, int Sine)
        {
            for (int i = 0; i < DRAWING_GAME.GetLength(1); i++)
            {
                Console.SetCursorPosition(Lengths[Row, Row], i + Sine);
                Console.Write(DRAWING_GAME[Row, i]);
            }
        }
        static void LetMeHaveAGo(string[,] DRAWING_GAME, int[,] Lengths)
        {
            while (true)
            {
                for (int i = 0; i < DRAWING_GAME.GetLength(0); i++)
                {
                    double timestamp = Stopwatch.GetTimestamp();
                    double seconds = timestamp / Stopwatch.Frequency;

                    int Sine = (int)Math.Round((Math.Sin(seconds + 0.6 * i * -1) + 1) * 3);

                    PrintLetter(DRAWING_GAME, i, Lengths, Sine);
                } 
            }
            Console.WriteLine();
        }
    }
}
