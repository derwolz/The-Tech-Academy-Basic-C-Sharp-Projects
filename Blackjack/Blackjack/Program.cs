using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Here is some text";
            File.WriteAllText(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\Blackjack\\log.txt", text);
            text = File.ReadAllText(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\Blackjack\\log.txt");
            Console.WriteLine(text);


            Console.WriteLine("BlackJack Game");
            Console.WriteLine("What is Player 1's name");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you want to play with today");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to join a game of BlackJack, {0}", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\Blackjack\\Cardlog.txt"))
                {
                    file.WriteLine(player.id);
                }
                Game game = new Casino.BlackJack.BlackJack();
                game += player;
                player.isActive = true;
                while (player.isActive && player.Balance > 0)
                {
                    game.Play();
                    
                }
                game -= player;
                Console.WriteLine("{0} Thank you for playing", player.Name);
            }
            Console.WriteLine("Quit");
            Console.ReadLine();

           

            
            
            


        }
        
        
    }
}
