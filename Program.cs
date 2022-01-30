using System;

namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder game");

            SnakeAndLadderGame game = new SnakeAndLadderGame();
            game.DiceRoll();
        }
        
    }
}