using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_p124
{
    public abstract class Person //step 1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void SayName(); // step2
    }
}
