using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Part_2
{
    public class NegativeException : Exception
    {
        public NegativeException() : base() { }
        public NegativeException(string message) : base(message) { }
    }
}
