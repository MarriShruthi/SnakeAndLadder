using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Game
    {
        const int START_POSITION = 0;
        public void Play()
        {
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine(" Player die roll position = "+dieValue);
        }
    }
}


