using System;

namespace Return_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Num_returner newnum = new Num_returner();
            Console.WriteLine("12 + 5 = {0}.\nMultiplying decimal 12.3 by 5: {1}.\nConverting string 12 to integer then subtracting 3: {2}",
                newnum.addfive(12), newnum.addfive(12.7m), newnum.addfive("12"));
        }
    }
}
