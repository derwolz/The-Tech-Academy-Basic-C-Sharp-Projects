using System;
using System.Collections.Generic;
using System.Text;

namespace General_Methods
{
    class NumberChanger
    {
        int num { get; set; }
        public void Outter(out int num, int num2)
        {
            num = num2 / 2;
            return;
        }

        
    }
}
