using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class BlackJack : Game
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack Players");
            base.ListPlayers();

        }
    }
}
