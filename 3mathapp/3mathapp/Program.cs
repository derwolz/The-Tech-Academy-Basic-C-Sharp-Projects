using System;

namespace _3mathapp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Give me a number");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0} plus 5 = {1}", num, Mather.addfive(num));
                Console.WriteLine("{0} times 5 = {1}", num, Mather.MultiplybyFive(num));
                Console.WriteLine("{0} minus 5 = {1}", num, Mather.SubtractFive(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a number");
                return;
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
