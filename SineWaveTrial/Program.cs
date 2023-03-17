using System;
using System.Diagnostics;
using System.Threading;

namespace SineWaveTrial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] DRAWING_GAME = new string[12][];

            int[][] Lengths = new int[13][];

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

            DRAWING_GAME[1] = new string[12];
            DRAWING_GAME[1][1] = "          ";
            DRAWING_GAME[1][2] = "▓█████▄";
            DRAWING_GAME[1][3] = "▒██▀ ██▌";
            DRAWING_GAME[1][4] = "░██   █▌";
            DRAWING_GAME[1][5] = "░▓█▄   ▌";
            DRAWING_GAME[1][6] = "░▒████▓ ";
            DRAWING_GAME[1][7] = " ▒▒▓  ▒ ";
            DRAWING_GAME[1][8] = " ░ ▒  ▒";
            DRAWING_GAME[1][9] = " ░ ░  ░";
            DRAWING_GAME[1][10] = "   ░";
            DRAWING_GAME[1][11] = " ░";

            DRAWING_GAME[2] = new string[12];
            DRAWING_GAME[2][1] = "          ";
            DRAWING_GAME[2][2] = " ██▀███";
            DRAWING_GAME[2][3] = "▓██ ▒ ██";
            DRAWING_GAME[2][4] = "▓██ ░▄█ ";
            DRAWING_GAME[2][5] = "▒██▀▀█▄ ";
            DRAWING_GAME[2][6] = "░██▓ ▒██▒";
            DRAWING_GAME[2][7] = "░ ▒▓ ░▒▓░";
            DRAWING_GAME[2][8] = "  ░▒ ░ ▒░";
            DRAWING_GAME[2][9] = "  ░░   ░ ";
            DRAWING_GAME[2][10] = "   ░     ";
            DRAWING_GAME[2][11] = "";

            //            Lengths[3][] = 9;

            //            string A = @"

            //  ▄▄▄      
            //▒▒████▄    
            //▒▒██  ▀█▄  
            // ░██▄▄▄▄██ 
            //▒ ▓█   ▓██▒
            //░ ▒▒   ▓▒█░
            //░  ▒   ▒▒ ░
            //   ░   ▒   
            //       ░  ░
            //            ";
            //            DRAWING_GAME[3] = A;
            //            Lengths[4] = 11;

            //            string W = @"

            // █     █░
            //▓█░ █ ░█░
            //▒█░ █ ░█ 
            //░█░ █ ░█ 
            //░░██▒██▓ 
            //░ ▓░▒ ▒  
            //  ▒ ░ ░  
            //  ░   ░  
            //    ░    
            //          ";
            //            DRAWING_GAME[4] = W;
            //            Lengths[5] = 9;

            //            string I = @"

            // ██▓ 
            //▓██▒ 
            //▒██▒▓
            //░██░▓
            //░██░▒
            //░▓  ░
            // ▒ ░░
            // ▒ ░ 
            // ░  
            //       ";
            //            DRAWING_GAME[5] = I;
            //            Lengths[6] = 5;

            //            string N = @"

            //███▄    █ 
            //██ ▀█   █ 
            //██  ▀█ ██▒
            //██▒  ▐▌██▒
            //██░   ▓██░
            // ▒░   ▒ ▒ 
            // ░░   ░ ▒░
            //  ░   ░ ░ 
            //        ░ 
            //           ";
            //            DRAWING_GAME[6] = N;
            //            Lengths[7] = 10;

            //            string G = @"

            //  ▄████    
            // ██▒ ▀█▒   
            //▒██░▄▄▄░   
            //░▓█  ██▓   
            //░▒▓███▀▒   
            // ░▒   ▒    
            //  ░   ░    
            //░ ░   ░    
            //      ░    
            //         ";
            //            DRAWING_GAME[7] = G;
            //            Lengths[8] = 8;

            //            string G2 = @"

            //  ▄████ 
            // ██▒ ▀█▒
            //▒██░▄▄▄░
            //░▓█  ██▓
            //░▒▓███▀▒
            // ░▒   ▒ 
            //  ░   ░ 
            //░ ░   ░ 
            //      ░ 
            //         ";
            //            DRAWING_GAME[8] = G2;
            //            Lengths[9] = 8;

            //            string A2 = @"

            // ▄▄▄      
            //▒████▄    
            //▒██  ▀█▄  
            //░██▄▄▄▄██ 
            // ▓█   ▓██▒
            // ▒▒   ▓▒█░
            //  ▒   ▒▒ ░
            //  ░   ▒   
            //      ░  ░
            //           ";
            //            DRAWING_GAME[9] = A2;
            //            Lengths[10] = 10;

            //            string M = @"

            // ███▄ ▄███▓
            //▓██▒▀█▀ ██▒
            //▓██    ▓██░
            //▒██    ▒██ 
            //▒██▒   ░██▒
            //░ ▒░   ░  ░
            //░  ░      ░
            //░      ░   
            //       ░   
            //            ";
            //            DRAWING_GAME[10] = M;
            //            Lengths[11] = 11;

            //            string E = @"

            //▓█████
            //▓█   ▀
            //▒███  
            //▒▓█  ▄
            //░▒████▒
            //░░ ▒░ ░
            // ░ ░  ░
            //   ░  
            //   ░  ░
            //         ";
            //            DRAWING_GAME[11] = E;
            //            Lengths[12] = 7;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.CursorVisible = true;

            int Width = Console.WindowWidth;

            int Height = Console.WindowHeight;

            for (int i = 1; true; i++)
            {
                double timestamp = Stopwatch.GetTimestamp();
                double seconds = timestamp / Stopwatch.Frequency;

                Console.SetCursorPosition(0, (int)Math.Round((Math.Sin(seconds + 0.1 * i) + 1) * 3));
                for (int j = 1; i < DRAWING_GAME.GetLength(0); i++)
                {
                    Console.Write(DRAWING_GAME[1][j]);
                }

                Console.SetCursorPosition(20, (int)Math.Round((Math.Sin(seconds + 0.1 * i) + 1) * 3));

                for (int j = 1; i < DRAWING_GAME.GetLength(0); i++)
                {
                    Console.Write(DRAWING_GAME[2][j]);
                }

                if (i == 11)
                    i = 1;
            }
            //Console.WriteLine("Height: {0}, Width{1}", Height, Width);
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
        static void SecondTry(string[] DRAWING_GAME, int[] Lengths)
        {
            //for (int i = 0; true; i++)
            //{
            Console.SetCursorPosition(30, 0);
            Console.Write(DRAWING_GAME[1]);

            //Console.SetCursorPosition(8, 1);
            //Console.Write(DRAWING_GAME[2]);
            //}
        }
    }
}
