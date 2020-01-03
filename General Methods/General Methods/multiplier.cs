using System;
using System.Collections.Generic;
using System.Text;

namespace General_Methods
{
    static class multiplier
    {
        static public int Multiply(int x, int y, out double z)
        {
            int result = x * y;
            z = x / y;
            return result;
        }
        static public int Multiply(int x, int y)
        {
            int result = x * y;
            return result;
        }
    }
}
