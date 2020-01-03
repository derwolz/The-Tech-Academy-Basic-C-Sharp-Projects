using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_p124
{
    class Employee : Person //step 3
    {
        public int Id { get; set; }
        public override void SayName() //step 4
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
