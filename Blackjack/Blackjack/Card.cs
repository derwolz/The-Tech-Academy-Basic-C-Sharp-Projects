using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Card
    {
        //suit
        public enum Suit
        {
            Spades,
            Hearts,
            Diamonds,
            Clubs,
        }
        public enum Face
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Jack,
            Queen,
            King,
        }
        public Suit suit { get; set; }
        //value
        public Face face { get; set; }
        //faceup
        public bool isFaceUp { get; set; }
        
    }
}
