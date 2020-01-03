using System;
using System.Collections.Generic;
namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------Step 1------------------------------------------------------
            string[] string1 = new string[3];
            Console.WriteLine("Here we will create an array of strings 3 in length");
            for (int i = 0; i < string1.Length; i++) // this fulfills number 4
            {
                Console.WriteLine($"Word {i + 1}");
                string1[i] = Console.ReadLine();
            }
            for (int i = 0; i < string1.Length; i++)// This also fulfills number 4
            {
                Console.WriteLine(string1[i]);
            }
            //---------------------------------------------------------------------------------------------------

            bool exitProgram = false; // This will create an infinite loop fulfilling step 2
            while (!exitProgram)
            {   
                Console.WriteLine("Press escape to exit loop");
                if (Console.ReadKey().Key == ConsoleKey.Escape) // this will fix the infinite loop fullfilling step 3
                { exitProgram = true; }
            
            }
            Console.Clear();


            for (int i = string1.Length-1; 0 <= i; i--) //This fulfills step 5
            {
                Console.WriteLine(string1[i]);
            }
            List<string> names = new List<string>(); //This fulfills step 6
            names.Add("Mary");
            names.Add("Sally");
            names.Add("Johnathan");
            names.Add("Jesse");
            names.Add("Jennifer");
            names.Add("Derek");
            names.Add("Charles");
            bool exitloop = false;
            while (!exitloop)
            {
                Console.WriteLine("Type in a name to see the index of the name");
                string query = Console.ReadLine();
                if (!names.Contains(query))
                    Console.WriteLine($"This list does not contain {query}."); //This fulfills step 7
                foreach (string name in names)
                {
                    if (name == query)
                    {
                        Console.WriteLine($"{name} is located at index {names.IndexOf(name)}");
                        exitloop = true; //----------------------------------- this fulfills step 8
                    }
                }
            }
            exitloop = false;

            //---------------------------------This adds names to step 6 so there are duplicates to search for---------------------------------------
            Console.WriteLine("Adding more names");
            names.Add("Derek");
            names.Add("Charles");
            //----------------------------------------------------------------------------------------------------------------------------------------

            while (!exitloop) //---------------This loop searches for duplicates and returns indeces for step 6's new duplicates----------------------
            {
                Console.WriteLine("Type in a name to see if there is a duplicate");
                string query = Console.ReadLine();
                if (!names.Contains(query))
                {
                    Console.WriteLine($"This list does not contain {query}.");// This fulfills step 10
                    
                }
                foreach (string name in names)
                {
                    if (query == name)
                    {
                        Console.WriteLine($"{query} is located at {names.IndexOf(name)}"); // this fulfills step 9
                        exitloop = true;
                    }
                }
            
            }

            //--------step 11----------//

            List<string> newstring = new List<string>();
            List<string> checkstring = new List<string>();
            newstring.Add("this");
            newstring.Add("story");
            newstring.Add("story");
            newstring.Add("this");
            newstring.Add("is terrible");
            foreach (string nustring in newstring)
            {
                if (!checkstring.Contains(nustring))
                    checkstring.Add(nustring);
                else
                    Console.WriteLine($"{nustring} already exists");
            }
            Console.Read();
        }
    }
}
