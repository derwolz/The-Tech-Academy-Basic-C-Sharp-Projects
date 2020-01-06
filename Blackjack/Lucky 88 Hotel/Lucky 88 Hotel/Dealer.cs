using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public Deck Deck { get; set; }
        
        public void Deal(List<Card> Hand)
        {
            
            Hand.Add(Deck.Cards.First());
            string text = Deck.Cards.First().ToString() + "\n";
            Console.WriteLine(text);
            
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\Blackjack\\CardLog.txt",true))
            {
                file.WriteLine("{0} Drawn at {1}", text, DateTime.Now);
            }
            
            Deck.Cards.RemoveAt(0);
        }
    }
}
