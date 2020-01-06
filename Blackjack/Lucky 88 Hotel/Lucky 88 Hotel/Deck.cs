using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            this.Cards = new List<Card>();
            
     
            for (int i = 0;i < 13; i++)
            {
                for ( int itwo = 0; itwo <4; itwo++)
                {
                    
                    Card card = new Card();
                    card.face = (Card.Face)i;
                    
                    card.suit = (Card.Suit)itwo;
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
