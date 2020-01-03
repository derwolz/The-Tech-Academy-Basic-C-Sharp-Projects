using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public void ListPlayers()
        {
            { 
                foreach (string Player in Players)
                {
                    Console.WriteLine(Player);
                }
            }
        }
    }
}
