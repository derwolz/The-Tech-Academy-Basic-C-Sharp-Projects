using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game1 = new BlackJack();
            
            Player player1 = new Player();
            player1.Name = "jesse";
            game1 += player1;
            game1 -= player1;
            game1.ListPlayers();

            
          
        }
        
        
    }
}
