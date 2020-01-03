using System;
using System.Collections.Generic;
using System.Text;

namespace Two_parameter_method
{
    class NumberManipulator
    {
        public int add7(int x)
        {
            x = x + 7;
            return x;
        }
        public int divTenBy(int x)
        {
            x = x / 10;
            return x;
        }
        public bool isEven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
        public void Changebothtofive(int x, out int f)
        {

            f = x+2;
            return;

        }
    }
}
