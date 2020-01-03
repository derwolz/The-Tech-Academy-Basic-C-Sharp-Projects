using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new BlackJack();
            game.Players = new List<string>() { "Billy", "Willy", "Jilly" };
            game.ListPlayers();

            
          
        }
        
        
    }
}
