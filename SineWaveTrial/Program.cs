using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            string[,] DRAWING_GAME;

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

            string SecondPrompt = @"
██████╗ ███████╗ ██████╗ ██╗███████╗████████╗███████╗██████╗ 
██╔══██╗██╔════╝██╔════╝ ██║██╔════╝╚══██╔══╝██╔════╝██╔══██╗
██████╔╝█████╗  ██║  ███╗██║███████╗   ██║   █████╗  ██████╔╝
██╔══██╗██╔══╝  ██║   ██║██║╚════██║   ██║   ██╔══╝  ██╔══██╗
██║  ██║███████╗╚██████╔╝██║███████║   ██║   ███████╗██║  ██║
╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝
 ";

            int[] LetterWidth = { 0, 8, 9, 10, 9, 4, 11, 8, 11, 10, 11, 7 };

            int[] SecondLetterWidth = { 0, 8, 8, 9, 3, 8, 9, 8, 8 };

            int[] Lengths = new int[LetterWidth.Length];

            int[] SecondLengths = new int[SecondLetterWidth.Length];

            DRAWING_GAME = PromptToArray(SecondPrompt, SecondLetterWidth);

            SetToZero(SecondLengths);//seting the length array to zero

            void SetToZero(int[] Length)//funciton that sets an array to zero
            {
                for (int i = 0; i < Length.GetLength(0); i++)
                    Length[i] = 0;
            }

            for (int i = 0; i < DRAWING_GAME.GetLength(0); i++)//Inserting the length of each letter
                SecondLengths[i + 1] = DRAWING_GAME[i, 0].Length;

            Sum(SecondLengths);//suming the letters length verticaly

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.CursorVisible = false;

            LetMeHaveAGo(DRAWING_GAME, SecondLengths);
        }
        static string[,] PromptToArray(string Prompt, int[] Lengths)//all we need is the prompt and a array of the length of each letter ||&&|| and to change the arrays size
        {
            string[,] Letters = new string[Lengths.Length - 1, Lengths.Length];

            List<string> Lines = new List<string>();

            int Index = 0;

            while (Prompt[Index] == ' ' || Prompt[Index] == '\r' || Prompt[Index] == '\n')//at the end of each line there is a char \r and \n
                Index++;

            for (int i = 0; i < Letters.Length; i++)//Make a list with literally each line as a variable
            {
                Lines.Add(LineToString(Prompt, ref Index));

                if (Index != Prompt.Length && Prompt[Index] == '\r')
                    Index += 2;

                if (Index == Prompt.Length)
                    break;
            }

            int Largest = FindLargestNumber(Lines);

            for (int i = 0; i < Lines.Count; i++)//adding ' '(space) to the lines if needed
            {
                for (int j = 0; Lines[i].Length != Largest; j++)
                {
                    Lines[i] += ' ';
                }
            }

            Sum(Lengths);

            for (int i = 0; i <= Lines.Count; i++)//adding each letter to the array line by line
            {
                for (int j = 0; j < Lines.Count; j++)
                {
                    Letters[i, j + 1] = Lines[j].Substring(Lengths[i], Lengths[i + 1] - Lengths[i]);
                }
            }

            AddSpaceToTopAndBottom(Letters);

            return Letters;

            string LineToString(string pro, ref int Ind)//takes a line from a string and making into another string
            {
                string Line = "";

                while (Ind != pro.Length && pro[Ind] != '\r')
                {
                    Line += pro[Ind];
                    Ind++;
                }
                return Line;
            }
            int FindLargestNumber(List<string> numbers)//finding the largest line length
            {
                int largest = numbers[0].Length;
                for (int i = 1; i < Lines.Count; i++)
                {
                    if (Lines[i].Length > largest)
                    {
                        largest = Lines[i].Length;
                    }
                }
                return largest;
            }
            void AddSpaceToTopAndBottom(string[,] StringArray)//adding space to the top and to the bottom of the letters
            {
                for (int i = 0; i < StringArray.GetLength(0); i++)
                {
                    int LargestLine = StringArray[i, 1].Length;

                    for (int j = 0; j < StringArray.GetLength(1); j++)
                    {
                        if (j != 0 && j != StringArray.GetLength(1) - 1)
                        {
                            if (StringArray[i, j].Length > LargestLine)
                                LargestLine = StringArray[i, j].Length;
                        }
                    }

                    string space = "";

                    for (int j = 0; j < LargestLine; j++)
                    {
                        space += ' ';
                    }

                    StringArray[i, 0] = space;
                    StringArray[i, StringArray.GetLength(1) - 1] = space;
                }
            }
        }
        static void PrintArray<T>(T[] Lengths)//prints an array
        {
            for (int i = 0; i < Lengths.Length; i++)
            {
                Console.Write(Lengths[i] + "\t|");
                Console.WriteLine();
            }
        }
        static void Sum(int[] Lengths)//summing an int array to zero
        {
            for (int i = 0; i < Lengths.Length; i++)
            {
                int Count = 0;

                for (int T = Lengths.Length - 1 - i; T > 0; T--)
                    Count += Lengths[T];

                Lengths[Lengths.Length - 1 - i] = Count;
            }
        }
        static void PrintLetter(string[,] DRAWING_GAME, int Row, int[] Lengths, int Sine)//printing a letter
        {
            for (int i = 0; i < DRAWING_GAME.GetLength(1); i++)
            {
                Console.SetCursorPosition(Lengths[Row], i + Sine);
                Console.Write(DRAWING_GAME[Row, i]);
            }
        }
        static void LetMeHaveAGo(string[,] DRAWING_GAME, int[] Lengths)//the idea
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
