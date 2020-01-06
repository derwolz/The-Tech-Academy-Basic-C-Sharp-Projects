using System;

namespace Exception_Handling_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            try
            {
                bool isNumber = false;
                int query = 0;
                while (!isNumber)
                {
                    isNumber = int.TryParse(Console.ReadLine(), out query);
                    if (!isNumber) Console.WriteLine("try entering a number");
                }
                
                if (query < 0) throw new NegativeException();
                if (query == 0) throw new ZeroException();
                Console.WriteLine(DateTime.Now.AddYears(-(query)));
            }
            catch (NegativeException)
            {
                Console.WriteLine("You aren't even born yet");
            }
            catch (ZeroException)
            {
                Console.WriteLine("I should call NBC and get a special about a baby using the computer");
            }
            catch (FormatException)
            {
                Console.WriteLine("You should write a number only");
            }
            catch (Exception)
            {
                Console.WriteLine("How did you even get here?");
            }
        }
    }
}
