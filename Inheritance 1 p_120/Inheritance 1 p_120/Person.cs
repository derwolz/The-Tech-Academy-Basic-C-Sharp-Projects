using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1_p_120
{
    class Person // step 1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName() // step 2
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
