using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blackjack
{
    public class Dealer : Player
    {
        public Deck Deck { get; set; }
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
