using System;
using System.Collections.Generic;
using System.Text;

namespace Casino

{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _Bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public abstract void Play();
        public Dictionary<Player, int> Bets { get { return _Bets; } set{ _Bets= value;} }
        public Game()
            {
            this.Players = new List<Player>();
            }

        public virtual void ListPlayers()
        {
            { 
                foreach (Player player in Players)
                {
                    Console.WriteLine(player.Name.ToString());
                }
            }
        }
        

    }
}
