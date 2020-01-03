using System;

namespace General_Methods
{
     class Program
    {
        static void Main(string[] args)
        {
            int resultant = 0;
            double divided = 0;
            NumberChanger numberChanger = new NumberChanger();
            Console.WriteLine("Enter a number");
            try
            {
                int number1 = Int32.Parse(Console.ReadLine());
                numberChanger.Outter(out resultant, number1);
                Console.WriteLine("Your number divided by 2 is: {0}", resultant);
                Console.ReadLine();
                Console.WriteLine("Enter a second Number");
                int number2 = Int32.Parse(Console.ReadLine());
                resultant = multiplier.Multiply(number1, number2, out divided);
                Console.WriteLine("{0} times {1} equals {2} but divided equals {3}", number1, number2, resultant, divided);
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a Number.");
            }
        }
    }
}
