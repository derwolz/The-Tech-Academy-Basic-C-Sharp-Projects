using System;
using System.Collections.Generic;
namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] string1 = new string[3];
            Console.WriteLine("Here we will create an array of strings 3 in length");
            for (int i = 0; i < string1.Length; i++)
            {
                Console.WriteLine($"Word {i + 1}");
                string1[i] = Console.ReadLine();
            }
            for (int i = 0; i < string1.Length; i++)
            {
                Console.WriteLine(string1[i]);
            }
            //for (int i = string1.Length - 1; i < string1.Length; i--)
            //{
            //    Console.WriteLine(string1[i]);
            //}
            for (int i = string1.Length-1; i >= 0; i--)
            {
                Console.WriteLine(string1[i]);
            }
            List<string> names = new List<string>();
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
                    Console.WriteLine($"This list does not contain {query}.");
                foreach (string name in names)
                {
                    if (name == query)
                    {
                        Console.WriteLine($"{name} is located at index {names.IndexOf(name)}");
                        exitloop = true;
                    }
                }
            }
            exitloop = false;
            names.Add("Derek");
            
            while (!exitloop)
            {
                Console.WriteLine("Type in a name to see if there is a duplicate");
                string query = Console.ReadLine();
                if (!names.Contains(query))
                {
                    Console.WriteLine($"This list does not contain {query}.");
                    
                }
                foreach (string name in names)
                {
                    if (query == name)
                    {
                        Console.WriteLine($"{query} is located at {names.IndexOf(name)}");
                        exitloop = true;
                    }
                }
            
            }
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
