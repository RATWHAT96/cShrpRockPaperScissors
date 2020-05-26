using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt; // for the CPU input
            int scorePlayer = 0;
            int scoreComputer = 0;
            
            Console.WriteLine("Choose Between ROCK PAPER & SCISSOR?   ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();
            
            randomInt = rnd.Next(1,4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WINS!!!\n\n");
                        scorePlayer ++;
                    }
                    else if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("COMPUTER WINS!!!\n\n");
                        scoreComputer++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                                        Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("COMPUTER WINS!!!\n\n");
                        scoreComputer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!\n\n");
                    }
                    else if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("PLAYER WINS!!!\n\n");
                        scorePlayer ++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                                        Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!!!\n\n");
                        scorePlayer ++;                                            
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("COMPUTER WINS!!!\n\n");
                        scoreComputer++;                        
                    }
                    else if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("DRAW!\n\n");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry!!!");
                    break;
            }

        }
    }
}