using System;

namespace Struct_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 11000.000003m;
            Console.WriteLine(num1.Amount);
        }
    }
}
