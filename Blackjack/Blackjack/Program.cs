using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NumberManipulator num1 = new NumberManipulator();
            Console.WriteLine("Give me a number");
            try 
            { 
                int numquery = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{numquery} added to 7 is {num1.add7(numquery)}");
                Console.WriteLine($"10 divided by {numquery} is {num1.divTenBy(numquery)}");
                Console.WriteLine($"Is {numquery} an even number? {num1.isEven(numquery)}");

            }
            catch (FormatException) { Console.WriteLine("that is not a number"); }
            catch (DivideByZeroException) { Console.WriteLine("Cannot divide by zero"); }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here is a randomly sorted deck of standard playing cards");

            Deck deck = new Deck();
            Console.WriteLine(deck.Cards.Count);
            deck = Shuffle(deck);
            foreach ( Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
        }
        public static Deck Shuffle(Deck deck)
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
            return deck;
        }
    }
}
