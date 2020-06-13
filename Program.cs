using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// need to do input validation for the strings and the number of rounds, sort out try and catch

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt; // for the CPU input

            bool keepPlaying = true;
            
            // Main game loop
            while(keepPlaying == true){

                double numberOfWins;
                int scorePlayer = 0;
                int scoreComputer = 0;
                
                Console.WriteLine("Best of ...  ???\n");
                try{
                    int numberOfRounds = Convert.ToInt32(Console.ReadLine());
                } catch(System.FormatException) {
                    Console.WriteLine("Please input an interger");
                }
                
                // Logic to determine the number of wins necassary
                if (numberOfRounds % 2 == 0){
                    numberOfWins = (Math.Round(numberOfRounds/1.9) + 1);
                }
                else {
                    numberOfWins = Math.Round(numberOfRounds/1.9);
                }

                // rock paper scissors loop
                while(scoreComputer < numberOfWins && scorePlayer < numberOfWins){
                    Console.WriteLine("Choose Between ROCK PAPER & SCISSOR?   ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();
                    
                    randomInt = rnd.Next(1,4);

                    //Determises the outcome of the round
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


//Potential changes
//Change the while loop with scores to a while loop with the number of rounds and winner decided based of the greater score