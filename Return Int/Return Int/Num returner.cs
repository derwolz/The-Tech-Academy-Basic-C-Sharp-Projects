using System;
using System.Collections.Generic;
using System.Text;

namespace Return_Int
{
    class Num_returner
    {
        public int addfive(int x)
        {
            return x += 5;
        }
        public int addfive(decimal x)
        {
                int y = Convert.ToInt32(x * 5);
                return y;
        }
        public int addfive(string x)
        {
            try
            {
                int y = Convert.ToInt32(x);
                y -= 3;
                return y;
            }
            catch (FormatException)
            {
                Console.WriteLine("Cannot convert to int.");
                return -1;
            }
            
        }
    }
}
