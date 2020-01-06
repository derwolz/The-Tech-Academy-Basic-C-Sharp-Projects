using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Part_2
{
    public class ZeroException : Exception
    {
        public ZeroException() : base() { }
        public ZeroException(string message) : base(message) { }
    }
}
