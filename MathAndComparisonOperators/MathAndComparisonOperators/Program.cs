using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine($"For this to work User MUST input numbers");
            Console.WriteLine("1st number");
            int by50 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your number x50 = {by50 * 50}");
            Console.WriteLine("2nd number");
            int add25 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your number + 25 = {add25 + 25}");
            Console.WriteLine("3rd number");
            double divby125 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your number divided by 12.5 = {divby125 / 12.5}");
            Console.WriteLine("4th number");
            int isGreater50 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Is your number greater than 50? {isGreater50 > 50}");
            Console.WriteLine("5th number");
            int remof7 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Divided by 7 the remainder is: {remof7 % 7}");
            Console.Read();


        }
    }
}
