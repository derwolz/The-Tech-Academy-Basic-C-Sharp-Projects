using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Casino;


namespace Casino.BlackJack
{
    public class BlackJack : Game, IWalkAway
    {
        public BlackJack_Dealer dealer { get; set; }
        public override void Play()
        {
            
            Console.Clear();
            Console.WriteLine("\nNew Round\n");
            dealer = new BlackJack_Dealer();
            
            foreach (Player player in Players)
            {
                foreach (Card card in player.Hand.ToList())
                    player.Hand.Remove(card);//instantiates new Hand This should prevent cards from being kept
                player.Stay = false;
                
            }
            dealer.Hand = new List<Card>();
            dealer.Stay = false;
            dealer.Deck = new Deck(); //instantiates new deck, should dissallow  losing of cards
            dealer.Deck.Shuffle(7);
            Console.WriteLine("Place your bet");
            bool correctResponseType = false;
            foreach (Player player in Players) // get bets from all players
            {
                int bet = 0;
                while (!correctResponseType)
                {
                    Console.WriteLine("Player Balance: {0}", player.Balance);
                    correctResponseType = int.TryParse(Console.ReadLine(), out bet);
                    Console.WriteLine("Enter a number with no decimal value");
                }
                if (bet < 0) throw new Fraud_Exception();
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++) // Writes cards dealt to players
            {
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = BlackJackRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} Wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32(Bets[player] * 1.5 + Bets[player]);
                            Console.ReadLine();
                            return;
                        }
                    }
                }

                Console.WriteLine("Dealer: "); //dealer deals to self
                dealer.Deal(dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = BlackJackRules.CheckForBlackJack(dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer Has BlackJack \n");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            dealer.Balance += entry.Value;
                        }
                        Console.ReadLine();
                        return;
                    }
                }
            }
            foreach (Player player in Players) //asks players to hit or stay 
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your Cards are");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                        dealer.Deal(player.Hand);
                    bool busted = BlackJackRules.CheckForBust(player.Hand);
                    if (busted)
                    {
                        dealer.Balance += Bets[player];
                        Console.WriteLine("{0} You lose your bet of {1}. Your balance is now {2}", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "ya" || answer == "y" || answer == "yeah")
                            player.isActive = true;
                        else
                        {
                            player.isActive = false;
                        }
                        return;
                    }
                }
            }
            dealer.isBusted = BlackJackRules.CheckForBust(dealer.Hand); 
            dealer.Stay = BlackJackRules.ShouldDealerStay(dealer.Hand);
            while (!dealer.Stay && !dealer.isBusted) // If dealer should stay then deals until he is busted or fulfills reqs
            {
                Console.WriteLine("Dealer is hitting");
                dealer.Deal(dealer.Hand);
                dealer.isBusted = BlackJackRules.CheckForBust(dealer.Hand);
                dealer.Stay = BlackJackRules.ShouldDealerStay(dealer.Hand);
            }
            if (dealer.Stay) Console.WriteLine("Dealer is staying");
            if (dealer.isBusted) // divies gold if dealer busts
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} Won {1}!", entry.Key, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    dealer.Balance += entry.Value;
                }
                Console.ReadLine();
                return;
            }
            foreach (Player player in Players) // Final Nondrawing Comparison winner is most that doesn't get over 21
            {
                bool? playerWon = BlackJackRules.CompareHands(player.Hand, dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins");
                    player.Balance += Bets[player];
                } else if (playerWon == true)
                {
                    Console.WriteLine("{0} Won {1}!",player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    dealer.Balance -= (Bets[player]);
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y" || answer == "yeah")
                    player.isActive = true;
                else
                    player.isActive = false;
            }
            
        }
        
        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack Players");
            base.ListPlayers();

        }
        public void WalkAway(Player player)
        {
            throw new NotFiniteNumberException();
        }
    }
}
