using System;

namespace ConsoleApp2Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer,inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Do you want to play Rock Paper or Scissors? ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "rock";
                    Console.WriteLine("Computer chose rock");
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("TIE!!\n\n");
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("Player wins!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "rock")
                    {
                        Console.WriteLine("TIE\n\n");

                    }
                    break;
                case 2:
                    inputCPU = "Paper";
                    Console.WriteLine("Computer chose paper");
                    if (inputPlayer == "paper")
                    {
                        Console.WriteLine("Draw!!\n\n");
                    }
                    else if (inputPlayer == "rock")
                    {
                        Console.WriteLine("cpu wins!!\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("Player Wins\n\n");
                        scoreCPU++;

                    }
                    break;
                case 3:
                    inputCPU = "scissors";
                    Console.WriteLine("Computer chose scissors");
                    if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("TIE!!");

                    }
                    else if (inputPlayer == "rock")
                        Console.WriteLine("Player wins\n\n");
                        scorePlayer++;
                     
                     else if (inputPlayer == "paper")
                            Console.WriteLine("CPU wins!!\n\n");
                    
                    break;
            }
        }
    }
}