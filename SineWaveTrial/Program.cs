using System;
using System.Threading;
using System.Diagnostics;

namespace SineWaveTrial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] DRAWING_GAME = new string[12];

            int[] Lengths = new int[13];

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

            string D = @"
         
▓█████▄
▒██▀ ██▌
░██   █▌
░▓█▄   ▌
░▒████▓ 
 ▒▒▓  ▒ 
 ░ ▒  ▒
 ░ ░  ░
   ░
 ░
         ";
            DRAWING_GAME[1] = D;
            Lengths[2] = 8;

            string R = @"
          
 ██▀███
▓██ ▒ ██
▓██ ░▄█ 
▒██▀▀█▄ 
░██▓ ▒██▒
░ ▒▓ ░▒▓░
  ░▒ ░ ▒░
  ░░   ░ 
   ░     
          ";
            DRAWING_GAME[2] = R;
            Lengths[3] = 9;

            string A = @"
             
  ▄▄▄      
▒▒████▄    
▒▒██  ▀█▄  
 ░██▄▄▄▄██ 
▒ ▓█   ▓██▒
░ ▒▒   ▓▒█░
░  ▒   ▒▒ ░
   ░   ▒   
       ░  ░
            ";
            DRAWING_GAME[3] = A;
            Lengths[4] = 11;

            string W = @"
           
 █     █░
▓█░ █ ░█░
▒█░ █ ░█ 
░█░ █ ░█ 
░░██▒██▓ 
░ ▓░▒ ▒  
  ▒ ░ ░  
  ░   ░  
    ░    
          ";
            DRAWING_GAME[4] = W;
            Lengths[5] = 9;

            string I = @"
       
 ██▓ 
▓██▒ 
▒██▒▓
░██░▓
░██░▒
░▓  ░
 ▒ ░░
 ▒ ░ 
 ░  
       ";
            DRAWING_GAME[5] = I;
            Lengths[6] = 5;

            string N = @"
            
███▄    █ 
██ ▀█   █ 
██  ▀█ ██▒
██▒  ▐▌██▒
██░   ▓██░
 ▒░   ▒ ▒ 
 ░░   ░ ▒░
  ░   ░ ░ 
        ░ 
           ";
            DRAWING_GAME[6] = N;
            Lengths[7] = 10;

            string G = @"
          
  ▄████    
 ██▒ ▀█▒   
▒██░▄▄▄░   
░▓█  ██▓   
░▒▓███▀▒   
 ░▒   ▒    
  ░   ░    
░ ░   ░    
      ░    
         ";
            DRAWING_GAME[7] = G;
            Lengths[8] = 8;
            
            string G2 = @"
          
  ▄████ 
 ██▒ ▀█▒
▒██░▄▄▄░
░▓█  ██▓
░▒▓███▀▒
 ░▒   ▒ 
  ░   ░ 
░ ░   ░ 
      ░ 
         ";
            DRAWING_GAME[8] = G2;
            Lengths[9] = 8;

            string A2 = @"
             
 ▄▄▄      
▒████▄    
▒██  ▀█▄  
░██▄▄▄▄██ 
 ▓█   ▓██▒
 ▒▒   ▓▒█░
  ▒   ▒▒ ░
  ░   ▒   
      ░  ░
           ";
            DRAWING_GAME[9] = A2;
            Lengths[10] = 10;

            string M = @"
             
 ███▄ ▄███▓
▓██▒▀█▀ ██▒
▓██    ▓██░
▒██    ▒██ 
▒██▒   ░██▒
░ ▒░   ░  ░
░  ░      ░
░      ░   
       ░   
            ";
            DRAWING_GAME[10] = M;
            Lengths[11] = 11;

            string E = @"
         
▓█████
▓█   ▀
▒███  
▒▓█  ▄
░▒████▒
░░ ▒░ ░
 ░ ░  ░
   ░  
   ░  ░
         ";
            DRAWING_GAME[11] = E;
            Lengths[12] = 7;

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.CursorVisible = true;

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
    }
}
