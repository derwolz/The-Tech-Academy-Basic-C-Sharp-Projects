﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class BlackJack : Game, IWalkAway
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
        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
