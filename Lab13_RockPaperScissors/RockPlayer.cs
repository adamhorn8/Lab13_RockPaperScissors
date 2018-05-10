using System;
namespace Lab13_RockPaperScissors
{
    class RockPlayer : Player
    {

        override public Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
