using System;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        const int NO_PLAY_THE_PLAYER = 0, LADDER_MOVE = 1, SNAKE = 2, WIN_PLACE = 100;

        int playerPosition = 0; 

        Random random = new Random();

        public int DiceRoll()
        {
            return random.Next(1,7);
        }

        public void GamePlay()
        {
            int choice = random.Next(0,3);

            switch (choice)
            {
                case NO_PLAY_THE_PLAYER: break;
                case LADDER_MOVE:
                    this.playerPosition += DiceRoll();
                    break;
                case SNAKE:
                    this.playerPosition -= DiceRoll();
                    break;
                default:
                    break;
            }
            
        }
    }    
}