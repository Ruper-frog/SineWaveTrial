using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

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

            int[] Lengths = new int[12];

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
 ░";

            int[] LetterHeightAndWidth = { 0, 8, 9, 10, 9, 4, 11, 8, 11, 10, 11, 7 };

            PromptToArray(prompt, LetterHeightAndWidth);

            /*int Row = 0, Column = 0;

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
            DRAWING_GAME[Row, Column++] = "       ";*/

            //SetToZero(Lengths);

            void SetToZero(int[] Length)
            {
                for (int i = 0; i < Lengths.GetLength(0); i++)
                    Lengths[i] = 0;
            }

            //for (int i = 0; i < DRAWING_GAME.GetLength(0); i++)
            //    Lengths[i + 1] = DRAWING_GAME[i, 0].Length;

            //PrintArray(Lengths);

            //Sum(Lengths);

            //Console.Write("\n");

            //Console.WriteLine("\n\n");

            //PrintArray(Lengths);

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.CursorVisible = false;

            //Normal(prompt);

            //LetMeHaveAGo(DRAWING_GAME, Lengths);
        }
        static string[,] PromptToArray(string Prompt, int[] Lengths)
        {
            string[,] Letters = new string[Lengths.Length, Lengths.Length];

            List<string> Lines = new List<string>();

            int Index = 0;

            while (Prompt[Index] == ' ' || Prompt[Index] == '\r' || Prompt[Index] == '\n')//at the end of each line there is a char \r and \n
                Index++;

            for (int i = 0; i < Letters.Length; i++)
            {
                Lines.Add(LineToString(Prompt, ref Index));

                if (Prompt[Index] == '\r')
                    Index += 2;

                if (Index == Prompt.Length - 1)//you probably can keep track of the number of \n or \r that u passed
                    break;
            }

            Sum(Lengths);

            foreach (int i in Lengths)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= Lines.Count; i++)
            {
                for (int j = 0; j <= Lines.Count; j++)
                {
                    int HowMuch = Lengths[j + 1] - Lengths[j];

                    if (j == Lines.Count - 1)
                        HowMuch = Lengths[j] - Lines[i].Length;

                    Letters[i, j] = Lines[i].Substring(Lengths[j], HowMuch);
                }
            }

            return Letters;

            string LineToString(string pro, ref int Ind)
            {
                string Line = "";

                while (pro[Ind] != '\r' && Ind != pro.Length - 1)
                {
                    Line += pro[Ind];
                    Ind++;
                }
                return Line;
            }
        }
        static void PrintArray<T>(T[] Lengths)
        {
            for (int i = 0; i < Lengths.Length; i++)
            {
                Console.Write(Lengths[i] + "\t|");
                Console.WriteLine();
            }
        }
        static void Sum(int[] Lengths)
        {
            for (int i = 0; i < Lengths.Length; i++)
            {
                int Count = 0;

                for (int T = Lengths.Length - 1 - i; T > 0; T--)
                    Count += Lengths[T];

                Lengths[Lengths.Length - 1 - i] = Count;
            }
        }
        static void PrintLetter(string[,] DRAWING_GAME, int Row, int[] Lengths, int Sine)
        {
            for (int i = 0; i < DRAWING_GAME.GetLength(1); i++)
            {
                Console.SetCursorPosition(Lengths[Row], i + Sine);
                Console.Write(DRAWING_GAME[Row, i]);
            }
        }
        static void LetMeHaveAGo(string[,] DRAWING_GAME, int[] Lengths)
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
