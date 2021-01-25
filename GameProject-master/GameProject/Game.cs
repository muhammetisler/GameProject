using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Game
    {
        public Game(string gameName, int price)
        {
            this.GameName = gameName;
            this.Price = price;
        }

        public string GameName { get; set; }
        public int Price { get; set; }

    }
}
