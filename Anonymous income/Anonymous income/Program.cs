using System;

namespace Anonymous_income
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("How many Hours do you work per week?");
            double p1Hours = double.Parse(Console.ReadLine());
            Console.WriteLine("How much do you make per hour?");
            double p1Rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("How many Hours do you work per week?");
            double p2Hours = double.Parse(Console.ReadLine());
            Console.WriteLine("How much do you make per hour?");
            double p2Rate = double.Parse(Console.ReadLine());
            double p1Week = p1Hours * p1Rate;
            double p2Week = p2Hours * p2Rate;
            Console.WriteLine($"Weekly salary of Person 1: {p1Week}");
            Console.WriteLine($"Weekly salary of Person 2: {p2Week}");
            if (p1Week > p2Week)
            {
                Console.WriteLine("Person 1 makes more than person 2");
            }
            else if (p2Week > p1Week)
            {
                Console.WriteLine("Person 2 Makes more than person 1");
            }
            else
            {
                Console.WriteLine("Person 1 and Person 2 make the same amount");
            }
            Console.Read();

        }
    }
}
