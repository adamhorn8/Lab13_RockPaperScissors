using System;
namespace Lab13_RockPaperScissors
{
    class RandomPlayer : Player
    {
        override public Roshambo GenerateRoshambo()
        {
            Random RPS = new Random();
            return (Roshambo)RPS.Next(0, 3);

        }
    }
}
