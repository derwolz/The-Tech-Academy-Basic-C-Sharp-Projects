using System;
using System.Collections.Generic;
using System.Text;

namespace Casino
{
    public class Fraud_Exception : Exception
    {
        public Fraud_Exception() : base() { }
        public Fraud_Exception(string Message) : base(Message) { }
        
    }
}
