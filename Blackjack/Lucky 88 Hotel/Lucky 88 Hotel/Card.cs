using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public struct Card
    {
        public override string ToString()
        {
            return string.Format("{0} of {1}",face, suit);
        }
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
            Ten,
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
