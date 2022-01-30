using System;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        const int NO_PLAY_THE_PLAYER = 0, LADDER_MOVE = 1, SNAKE = 2, WIN_PLACE = 100;

        int playerPosition = 0, counter =0; 

        Random random = new Random();

        public int DiceRoll()
        {
            counter++;
            return random.Next(1,7);
        }

        public void GamePlay()
        {
            while (this.playerPosition < WIN_PLACE)
            {
                int choice = random.Next(0,3);

                switch (choice)
                {
                    case NO_PLAY_THE_PLAYER: break;
                    case LADDER_MOVE:
                        if (this.playerPosition + DiceRoll() <= 100)
                        {
                            this.playerPosition += DiceRoll();
                        }
                        break;
                        
                    case SNAKE:
                        if (this.playerPosition - DiceRoll() >= 0)
                        {
                            this.playerPosition -= DiceRoll();
                        }
                        else
                        {
                            this.playerPosition = 0;
                        }
                        break;
                    
                    default:
                        break;
                }

                Console.WriteLine("Player Position is:  "+this.playerPosition);
            
            }

            Console.WriteLine("Dice rolled Count is: "+counter);
        }    
    }
}