using System;

namespace SnakeAndLadderGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder game");

            SnakeAndLadder game = new SnakeAndLadder();
            game.DiceRoll();
            game.TwoPlayer();
        }
        
    }
}