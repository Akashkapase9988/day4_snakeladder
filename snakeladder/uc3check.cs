using System;
using System.Collections.Generic;
using System.Text;

namespace snakeladder
{
    public class uc3check
    {
        public static void check()
        {
            int player = 0;

            Random random = new Random();
            int optionCheck = random.Next(1,4 );
            if (optionCheck == 1)
            {
                Console.WriteLine("do not paly stay on same position");
            }
            else if (optionCheck == 2)
            {
                Console.WriteLine("player move forward");
                Random position = new Random();
                int empCheck = position.Next(1, 7);
                player += empCheck;          
            }

            else
            {
                Console.WriteLine("palyer move backword");
                Random position = new Random();
                int empCheck = position.Next(1, 7);
                player -= empCheck;
            }
            Console.WriteLine("player come in position : " + player);
        }
    }
}
