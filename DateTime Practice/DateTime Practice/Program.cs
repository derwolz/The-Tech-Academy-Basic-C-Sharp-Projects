using System;

namespace DateTime_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Give me a number");
            int numQuery = Int32.Parse(Console.ReadLine());
            Console.WriteLine("It will be {0}", DateTime.Now.AddHours(numQuery));
            Console.Read();
        }
    }
}
