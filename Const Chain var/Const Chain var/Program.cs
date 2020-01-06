using System;

namespace Const_Chain_var
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numOfBananas = 1;
            var whatishappening = new Class1();
            Console.WriteLine("Constant: {0} \nproperty1: {1} \nproperty2: {2}", numOfBananas, whatishappening.ThisNum, whatishappening.Name);
            Console.ReadLine();
        }
    }
}
