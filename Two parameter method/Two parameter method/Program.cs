using System;

namespace Two_parameter_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 19;
            NumberManipulator Two = new NumberManipulator();

            Console.WriteLine("X:{0} Y:{1}", x, y);
            Two.Changebothtofive(x:x, f: out y);
            Console.WriteLine("X:{0} Y:{1}", x, y);
            Console.ReadLine();
        }
    }
}
