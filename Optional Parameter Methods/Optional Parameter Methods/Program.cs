using System;

namespace Optional_Parameter_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
                Number_Outter newNumber = new Number_Outter();
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input a second number (or hit Enter to skip)");
            string num2String = Console.ReadLine();
            if (num2String == "")
                Console.WriteLine("{0} times nothing equals {1}", num1, newNumber.TimesMyNumbers(num1));
            else
                try
                {
                    int num2 = Convert.ToInt32(num2String);
                    Console.WriteLine("{0} times {1} equals {2}", num1, num2, newNumber.TimesMyNumbers(num1, num2));
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a number");
                }
        }
    }
}
