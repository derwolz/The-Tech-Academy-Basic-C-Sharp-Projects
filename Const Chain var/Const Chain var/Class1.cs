using System;
using System.Collections.Generic;
using System.Text;

namespace Const_Chain_var
{
    class Class1
    {
        public Class1() : this(1, "what")
        {        }
        public Class1(int num, string name)
        {
            this.ThisNum = num;
            this.Name = name;
        }
        public int ThisNum { get; set; }
        public string Name { get; set; }
    }
}
