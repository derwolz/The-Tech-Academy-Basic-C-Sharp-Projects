using System;
using System.Collections.Generic;
namespace ListandArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will Create a list of 3 string values");
            string[] string3 = new string[3];
            Console.WriteLine("What is your first name?");
            string3[0] = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string3[1] = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string3[2] = Console.ReadLine();
            Console.WriteLine("Now select a whole number between 1 and 3");
            int query = Int32.Parse(Console.ReadLine());
            if (query <= 3 && query >= 1)
                Console.WriteLine($"The Item you selected was {query} containing a value of {string3[query - 1]}");
            else
                Console.WriteLine("You aren't very good at listening to directions are you?");
            
            //This ends the first section------------------------------------------------------------------------------------------------------
            
            Console.WriteLine("The Computer will now create an array of 100 integers ");
            int[] intlist = new int[100];
            for (int x = 1; x < intlist.Length; x++)
            {
                intlist[x] = x * 10;
            }
            Console.WriteLine("Now select an integer between 1 and 100");
            query = Int32.Parse(Console.ReadLine());
            if (query <= 100 && query >= 1)
                Console.WriteLine($"You Selected {query} with a value of {intlist[query-1]}");
            else
                Console.WriteLine("You aren't very good at listening to directions are you?");
            //This ends the second section-----------------------------------------------------------------------------------------------------

            Console.WriteLine("Now Using a List you will create an index of strings");
            List<string> wordlist = new List<string>();
            Console.WriteLine("Select a number of items in the list");
            int item = Int32.Parse(Console.ReadLine());
            
            for (int items = 0; items < item; items++)
            {
                Console.WriteLine($"Word {items+1}");
                wordlist.Add(Console.ReadLine());
            }
            Console.WriteLine("Now Select an Index for the list");

            query = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The Word \"{wordlist[query - 1]}\" will be removed from the list");

            wordlist.Remove(wordlist[query - 1]);
            for (int x = 0; x < item-1; x++)
                Console.WriteLine(wordlist[x]);
            Console.Read();
        }
        
    }
}
