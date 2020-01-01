using System;

namespace Package_quote_program
{
    class Program
    {
        static void Main()
        {
            
            int maxweight = 50;
            int maxDimensions = 50;
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of the package?");
            int packageWeight = Int32.Parse(Console.ReadLine());
            if (packageWeight > maxweight)
            {
                Console.WriteLine("Package is too heavy to ship, Have a good day");
                Console.Read();
                Environment.Exit(0);
            }
            Console.WriteLine("What is the width of the package?");
            int packageWidth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            int packageHeight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            int packageLength = Int32.Parse(Console.ReadLine());
            if (packageHeight + packageWidth + packageLength > maxDimensions)
            {
                Console.WriteLine("That package is too large to ship. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }
            float quote = (packageWidth + packageHeight + packageLength) * packageWeight;
            quote = quote / 100;
            Console.WriteLine($"Your package will cost ${quote} to ship.");
            Console.Read();
            
         
        }
    }
}
