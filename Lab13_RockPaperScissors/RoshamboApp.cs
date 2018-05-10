using System;
namespace Lab13_RockPaperScissors
{
    public class RoshamboApp
    {
        public static void Game()
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors Game!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name");
            string Name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please select an opponent:");
                Console.WriteLine("1. Rock Player");
                Console.WriteLine("2. Random Player");
                Console.WriteLine("Please type 1 or 2");
                string OpponentChoiceS = Console.ReadLine();

                Player OpponentChoice;
                Roshambo RPSComp;

                if (OpponentChoiceS == "1")
                {
                    OpponentChoice = new RockPlayer();
                }
                else
                {
                    OpponentChoice = new RandomPlayer();
                }
                RPSComp = OpponentChoice.GenerateRoshambo();
                string RPSCompS = RPSComp.ToString();

                UserInput Human = new UserInput();

                Human.PlayerName = Name;

                string RPSInput = Human.GenerateRoshambo().ToString();

                Console.WriteLine();
                Console.WriteLine($"Your opponent chose {RPSCompS}");

                if (RPSCompS == "Paper")
                {
                    if (RPSInput == "R")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Lose!");
                    }
                    else if (RPSInput == "P")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Draw!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Win!");
                    }
                }
                else if (RPSCompS == "Scissors")
                {
                    if (RPSInput == "R")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Win!");
                    }
                    else if (RPSInput == "P")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Lose!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Draw!");
                    }
                }
                else
                {
                    if (RPSInput == "R")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Draw!");
                    }
                    else if (RPSInput == "P")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Win!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You Lose!");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to play again?");
                string PlayAgain = Console.ReadLine().ToLower();

                if (PlayAgain == "yes" || PlayAgain == "y")
                {

                }
                else
                {
                    break;
                }
            }
        }
    }
}
