using System;
using System.Collections.Generic;
using System.Text;

namespace snakeladder
{
    public class uc2rolldie
    {
        public static void rolldie() {

            Random random = new Random();
            int empCheck = random.Next(1, 7);
            Console.WriteLine(empCheck);

        }
    }
}
