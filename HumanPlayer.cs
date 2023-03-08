using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine($"Please select a number from 1 to {DiceSize}:");
            int playerRoll = int.Parse(Console.ReadLine());
            return playerRoll;
        }
    }
}