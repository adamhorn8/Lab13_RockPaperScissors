using System;
namespace Lab13_RockPaperScissors
{
    abstract class Player
    {
        public string PlayerName { get; set; }

        public Roshambo Val1 { get; set; }

        abstract public Roshambo GenerateRoshambo();
    }
}
