using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    public class Deck
    {
        public Deck()
        {
            this.Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Spades", "Clubs", "Hearts", "Diamonds" };
            List<string> Faces = new List<string>() {
            "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", 
            "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    this.Cards.Add(card);
                }
            }

            
            
        }
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random rand = new Random();
                while (this.Cards.Count > 0)
                {
                    int randomIndex = rand.Next(0, this.Cards.Count);
                    TempList.Add(this.Cards[randomIndex]);
                    this.Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
            return;
        }
        public List<Card> Cards { get; set; }
        
    }
}
