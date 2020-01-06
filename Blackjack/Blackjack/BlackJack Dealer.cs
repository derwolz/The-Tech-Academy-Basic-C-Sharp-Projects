using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class BlackJack_Dealer : Dealer
    {
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }

    }
}
