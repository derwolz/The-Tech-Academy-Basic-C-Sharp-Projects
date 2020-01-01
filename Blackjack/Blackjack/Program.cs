using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 19;
            two_outs Two = new two_outs();
         
            Console.WriteLine("X:{0} Y:{1}", x, y);
            Two.Changebothtofive(out x,out y);
            Console.WriteLine("X:{0} Y:{1}", x, y);
            
            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is a randomly sorted deck of standard playing cards");

            Deck deck = new Deck();
            Console.WriteLine(deck.Cards.Count);
            deck = Shuffle(deck, 5);
            foreach ( Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
        }
        public static Deck Shuffle(Deck deck, int times = 1)
        {
            for (int i = 0; i < times; i++)
            { 
                    List<Card> TempList = new List<Card>();
                Random rand = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = rand.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
        
    }
}
