using System;
using System.Collections.Generic;
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rand = new Random();
                int listlength = rand.Next(1, 10);
                List<int> intlist = new List<int>();
                for (int i = 0; i < listlength; i++)
                {
                    intlist.Add(rand.Next(1, 100));
                }
                Console.WriteLine("Choose a number to divide by");
                int numquery = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < listlength; i++)
                {
                    int oldnum = intlist[i];
                    intlist[i] = intlist[i] / numquery;
                    Console.WriteLine($"{oldnum} divided by {numquery} to the closest whole number equals {intlist[i]}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That is not a number.");
                string databaselog = ex.Message;
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
                string databaselog = ex.Message;
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
