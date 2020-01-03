using System;
using System.Collections.Generic;
using System.Text;

namespace Optional_Parameter_Methods
{
    class Number_Outter
    {
        public int TimesMyNumbers(int x, int y = 0)
        {
            int result = x * y;
            return result;
        }
    }
}
