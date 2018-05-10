using System;
namespace Lab13_RockPaperScissors
{
    class UserInput : Player
    {
        override public Roshambo GenerateRoshambo()
        {
            Console.WriteLine();
            Console.WriteLine("Ready?");

            Console.WriteLine("Rock, Paper, Scissors?");
            Console.WriteLine();
            Console.WriteLine("Please type R, P, or S");
            string RPSInput = Console.ReadLine().ToUpper();

            if (RPSInput == "R")
            {
                return Roshambo.Rock;
            }
            else if (RPSInput == "P")
            {
                return Roshambo.Paper;
            }
            else
            {
                return Roshambo.Scissors;
            }
        }
    }
}
