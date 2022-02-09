using System;

namespace SnakeAndLadderGame
{
    public class SnakeAndLadder
    {
        const int NO_PLAY_THE_PLAYER = 0, LADDER_MOVE = 1, SNAKE = 2, WIN_PLACE = 100, PLAYER_1 = 1, PLAYER_2 =2;

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

        public void TwoPlayer()
        {

            int intake = random.Next(1,3);

            while (this.playerPosition < WIN_PLACE)
            {
                switch (intake)
                {
                    case PLAYER_1:
                        GamePlay();
                        Console.WriteLine("Player 1 Position is:  "+this.playerPosition);
                        if (this.playerPosition >= 100)
                        {

                            System.Console.WriteLine("Player 1 Won..!!!");
                        }
                        break;
                    case PLAYER_2:
                         GamePlay();
                        Console.WriteLine("Player 2 Position is:  "+this.playerPosition);
                        if (this.playerPosition >= 100)
                        {
                            System.Console.WriteLine("Player 2 Won..!!!");
                        }
                        break;
                    default:
                        System.Console.WriteLine("Match tie");
                        break;
                }
                

            }
        }   
    }
}