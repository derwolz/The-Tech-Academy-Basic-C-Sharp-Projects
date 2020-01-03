using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public abstract void Play();
        public virtual void ListPlayers()
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
