using System;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        int playerPosition = 0; 

        Random random = new Random();

        public void DiceRoll()
        {
            int num = random.Next(1,7);
            Console.WriteLine(num);
        }
    }    
}