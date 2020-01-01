using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        //suit
        public string Suit { get; set; }
        //value
        public string Face { get; set; }
        //faceup
        public bool isFaceUp { get; set; }
        public Card()
        {
            this.Face = "Two";
            this.Suit = "Spades";
        }
    }
}
