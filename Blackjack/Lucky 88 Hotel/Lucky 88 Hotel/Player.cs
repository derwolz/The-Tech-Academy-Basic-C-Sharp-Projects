using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Player
    {
        
        private List<Card> _Hand = new List<Card>();
        public Player(string name, int beginningBalance = 100)
        {
            this.Hand = new List<Card>();
            this.Balance = beginningBalance;
            this.Name = name;
        }
        public List<Card> Hand { get { return _Hand; } set { value = _Hand; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public bool Stay { get; set; }
        public Guid id { get; set; }
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You cannot afford this bet.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
    }
}
