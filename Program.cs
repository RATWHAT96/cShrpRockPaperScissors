using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// need to do input validation for the strings and the number of rounds:
// could use while loop but maybe there is a better method

//Change the while loop with scores to a while loop with the number of rounds and winner decided based of the greater score



namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt; // for the CPU input

            bool keepPlaying = true;
            
            while(keepPlaying == true){
                Console.WriteLine("Best of ...  ???\n");
                int numberOfRounds = Convert.ToInt32(Console.ReadLine());
                double numberOfWins;
                int scorePlayer = 0;
                int scoreComputer = 0;
                if (numberOfRounds % 2 == 0){
                    numberOfWins = (Math.Round(numberOfRounds/1.9) + 1);
                }
                else {
                    numberOfWins = Math.Round(numberOfRounds/1.9);
                }

                while(scoreComputer < numberOfWins && scorePlayer < numberOfWins){
                    Console.WriteLine("Choose Between ROCK PAPER & SCISSOR?   ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();
                    
                    randomInt = rnd.Next(1,4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK\n");
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
                Console.WriteLine($"\n\nSCORES: \tPLAYER:\t{scorePlayer} \tCOMPUTER\t{scoreComputer}\n\n");
                }
                Console.WriteLine("Keep Playing?\n");
                Console.WriteLine("YES  OR   NO?\n");
                inputPlayer = Console.ReadLine();
                Console.Clear();
                if(inputPlayer == "NO"){
                    keepPlaying = false;
                }
            }
        }
    }
}