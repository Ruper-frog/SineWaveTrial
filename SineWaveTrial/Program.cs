using System;
using System.Diagnostics;
using System.Threading;

namespace SineWaveTrial
{
    internal class Program
    {
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

            int Num = 1;

            DRAWING_GAME[Num, 1] = "          ";
            DRAWING_GAME[Num, 2] = "▓█████▄";
            DRAWING_GAME[Num, 3] = "▒██▀ ██▌";
            DRAWING_GAME[Num, 4] = "░██   █▌";
            DRAWING_GAME[Num, 5] = "░▓█▄   ▌";
            DRAWING_GAME[Num, 6] = "░▒████▓ ";
            DRAWING_GAME[Num, 7] = " ▒▒▓  ▒ ";
            DRAWING_GAME[Num, 8] = " ░ ▒  ▒";
            DRAWING_GAME[Num, 9] = " ░ ░  ░";
            DRAWING_GAME[Num, 10] = "   ░";
            DRAWING_GAME[Num, 11] = " ░";



            Num++; 

            DRAWING_GAME[Num, 1] = "          ";
            DRAWING_GAME[Num, 2] = " ██▀███";
            DRAWING_GAME[Num, 3] = "▓██ ▒ ██";
            DRAWING_GAME[Num, 4] = "▓██ ░▄█ ";
            DRAWING_GAME[Num, 5] = "▒██▀▀█▄ ";
            DRAWING_GAME[Num, 6] = "░██▓ ▒██▒";
            DRAWING_GAME[Num, 7] = "░ ▒▓ ░▒▓░";
            DRAWING_GAME[Num, 8] = "  ░▒ ░ ▒░";
            DRAWING_GAME[Num, 9] = "  ░░   ░ ";
            DRAWING_GAME[Num, 10] = "   ░     ";
            DRAWING_GAME[Num, 11] = "";


            Num++;

            DRAWING_GAME[Num, 1] = "             ";
            DRAWING_GAME[Num, 2] = "  ▄▄▄      ";
            DRAWING_GAME[Num, 3] = "▒▒████▄    ";
            DRAWING_GAME[Num, 4] = "▒▒██  ▀█▄  ";
            DRAWING_GAME[Num, 5] = " ░██▄▄▄▄██ ";
            DRAWING_GAME[Num, 6] = "▒ ▓█   ▓██▒";
            DRAWING_GAME[Num, 7] = "░ ▒▒   ▓▒█░";
            DRAWING_GAME[Num, 8] = "░  ▒   ▒▒ ░";
            DRAWING_GAME[Num, 9] = "   ░   ▒   ";
            DRAWING_GAME[Num, 10] = "       ░  ░";
            DRAWING_GAME[Num, 11] = "           ";


            Num++; 
                         
            DRAWING_GAME[Num, 1] = "             ";
            DRAWING_GAME[Num, 2] = " █     █░";
            DRAWING_GAME[Num, 3] = "▓█░ █ ░█░";
            DRAWING_GAME[Num, 4] = "▒█░ █ ░█ ";
            DRAWING_GAME[Num, 5] = "░█░ █ ░█ ";
            DRAWING_GAME[Num, 6] = "░░██▒██▓ ";
            DRAWING_GAME[Num, 7] = "░ ▓░▒ ▒  ";
            DRAWING_GAME[Num, 8] = "  ▒ ░ ░  ";
            DRAWING_GAME[Num, 9] = "  ░   ░  ";
            DRAWING_GAME[Num, 10] = "    ░    ";
            DRAWING_GAME[Num, 11] = "             ";


            Num++;

            DRAWING_GAME[Num, 1] = "             ";
            DRAWING_GAME[Num, 2] = " ██▓ ";
            DRAWING_GAME[Num, 3] = "▓██▒ ";
            DRAWING_GAME[Num, 4] = "▒██▒▓";
            DRAWING_GAME[Num, 5] = "░██░▓";
            DRAWING_GAME[Num, 6] = "░██░▒";
            DRAWING_GAME[Num, 7] = "░▓  ░";
            DRAWING_GAME[Num, 8] = " ▒ ░░";
            DRAWING_GAME[Num, 9] = " ▒ ░ ";
            DRAWING_GAME[Num, 10] = " ░  ";
            DRAWING_GAME[Num, 11] = "             ";



            Num++; 

            DRAWING_GAME[Num, 1] = "             ";
            DRAWING_GAME[Num, 2] = "███▄    █ ";
            DRAWING_GAME[Num, 3] = "██ ▀█   █ ";
            DRAWING_GAME[Num, 4] = "██  ▀█ ██▒";
            DRAWING_GAME[Num, 5] = "██▒  ▐▌██▒";
            DRAWING_GAME[Num, 6] = "██░   ▓██░";
            DRAWING_GAME[Num, 7] = " ▒░   ▒ ▒ ";
            DRAWING_GAME[Num, 8] = " ░░   ░ ▒░";
            DRAWING_GAME[Num, 9] = "  ░   ░ ░ ";
            DRAWING_GAME[Num, 10] = "        ░ ";
            DRAWING_GAME[Num, 11] = "             ";



            Num++;

            DRAWING_GAME[Num, 1] = "             ";
            DRAWING_GAME[Num, 2] = "  ▄████    ";
            DRAWING_GAME[Num, 3] = " ██▒ ▀█▒ ";
            DRAWING_GAME[Num, 4] = "▒██░▄▄▄░  ";
            DRAWING_GAME[Num, 5] = "░▓█  ██▓ ";
            DRAWING_GAME[Num, 6] = "░▒▓███▀▒ ";
            DRAWING_GAME[Num, 7] = " ░▒   ▒  ";
            DRAWING_GAME[Num, 8] = "  ░   ░ ";
            DRAWING_GAME[Num, 9] = "░ ░   ░ ";
            DRAWING_GAME[Num, 10] = "      ░ ";
            DRAWING_GAME[Num, 11] = "";



            Num++;

            DRAWING_GAME[Num, 1] = "                  ";
            DRAWING_GAME[Num, 2] = "  ▄████ ";
            DRAWING_GAME[Num, 3] = " ██▒ ▀█▒";
            DRAWING_GAME[Num, 4] = "▒██░▄▄▄░";
            DRAWING_GAME[Num, 5] = "░▓█  ██▓";
            DRAWING_GAME[Num, 6] = "░▒▓███▀▒";
            DRAWING_GAME[Num, 7] = " ░▒   ▒ ";
            DRAWING_GAME[Num, 8] = "  ░   ░ ";
            DRAWING_GAME[Num, 9] = "░ ░   ░ ";
            DRAWING_GAME[Num, 10] = "      ░ ";
            DRAWING_GAME[Num, 11] = "                  ";



            Num++;

            DRAWING_GAME[Num, 1] = "                  ";
            DRAWING_GAME[Num, 2] = " ▄▄▄      ";
            DRAWING_GAME[Num, 3] = "▒████▄    ";
            DRAWING_GAME[Num, 4] = "▒██  ▀█▄  ";
            DRAWING_GAME[Num, 5] = "░██▄▄▄▄██ ";
            DRAWING_GAME[Num, 6] = " ▓█   ▓██▒";
            DRAWING_GAME[Num, 7] = " ▒▒   ▓▒█░";
            DRAWING_GAME[Num, 8] = "  ▒   ▒▒ ░";
            DRAWING_GAME[Num, 9] = "  ░   ▒   ";
            DRAWING_GAME[Num, 10] = "      ░  ░";
            DRAWING_GAME[Num, 11] = "                  ";



            Num++;

            DRAWING_GAME[Num, 1] = "                  "; 
            DRAWING_GAME[Num, 2] = " ███▄ ▄███▓"; 
            DRAWING_GAME[Num, 3] = "▓██▒▀█▀ ██▒"; 
            DRAWING_GAME[Num, 4] = "▓██    ▓██░"; 
            DRAWING_GAME[Num, 5] = "▒██    ▒██ "; 
            DRAWING_GAME[Num, 6] = "▒██▒   ░██▒"; 
            DRAWING_GAME[Num, 7] = "░ ▒░   ░  ░"; 
            DRAWING_GAME[Num, 8] = "░  ░      ░";
            DRAWING_GAME[Num, 9] = "░      ░   ";
            DRAWING_GAME[Num, 10] = "       ░   ";
            DRAWING_GAME[Num, 11] = "                  ";




            Num++;

            DRAWING_GAME[Num, 1] = "                  ";
            DRAWING_GAME[Num, 2] = "▓█████";
            DRAWING_GAME[Num, 3] = "▓█   ▀";
            DRAWING_GAME[Num, 4] = "▒███  ";
            DRAWING_GAME[Num, 5] = "▒▓█  ▄";
            DRAWING_GAME[Num, 6] = "░▒████▒";
            DRAWING_GAME[Num, 7] = "░░ ▒░ ░";
            DRAWING_GAME[Num, 8] = " ░ ░  ░";
            DRAWING_GAME[Num, 9] = "   ░  ";
            DRAWING_GAME[Num, 10] = "   ░  ░";
            DRAWING_GAME[Num, 11] = "                  ";

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.CursorVisible = true;
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
            for (int i = 1; true; i++)
            {
                double timestamp = Stopwatch.GetTimestamp();
                double seconds = timestamp / Stopwatch.Frequency;

                //(int)Math.Round((Math.Sin(seconds + 0.1 * i) + 1) * 3)

                Console.SetCursorPosition(Count, i);

                Console.Write(DRAWING_GAME[i]);

                if (i == 11)
                    i = 1; 
            }
        }
    }
}
