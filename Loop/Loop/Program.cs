using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 29;
            int guessedAge = 0;
            bool ageGuessed = false;
            
            do
            {

                Console.WriteLine("Guess my age");
                guessedAge = Int32.Parse(Console.ReadLine());
                if (guessedAge < age)
                    Console.WriteLine("Higher than that");
                else if (guessedAge > age)
                    Console.WriteLine("It's lower than that.");
                else if (guessedAge == age)
                {
                    Console.WriteLine("Yep that is it");
                    ageGuessed = true;
                }
                Console.WriteLine(guessedAge);
               // Console.Read();
            } 
            while (!ageGuessed);

            Console.WriteLine("lets write some stuff");
            bool endwhile = false;
            while (!endwhile)
            {
                ConsoleKey keypress = Console.ReadKey().Key;
                switch (keypress)
                {
                    case ConsoleKey.Escape:
                        
                        endwhile = true;
                        break;
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("You have pressed the letter A");
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.WriteLine("If you thought that would get you out");
                        Console.WriteLine("of the loop you should have pressed Escape");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"You have pressed {keypress}");
                        break;

                }
            }
           
            
            
        }
    }
}
