using System;
using System.Collections.Generic;
using System.Text;

namespace snakeladder
{
    class uc4100
    {
        public static void check100()
        {
            int player = 0;
            int noplay = 0;
            int snake = 2;
            int ladder = 1;
            int winning = 100;
            while (player <= winning)
            {
                
                Random random = new Random();
                int optionCheck = random.Next(1, 4);
                switch (optionCheck)
                {
                    case 0:
                        Console.WriteLine("do not paly stay on same position");
                        break;
                    case 1:
                
                        Console.WriteLine("player move forward");
                        Random position = new Random();
                        ladder = position.Next(1, 7);
                        player += ladder;
                        break;

                    case 2:
                
                    Console.WriteLine("palyer move backword");
                    Random Position = new Random();
                    snake = Position.Next(1, 7);
                       // if (player <= 0)
                        //    player = 0;
                        //else
                            player -= snake;
                        break;
                }
                
                Console.WriteLine("player come in position : " + player);

            }
        }
    }
}
