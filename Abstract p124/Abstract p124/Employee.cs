using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_p124
{
    class Employee : Person, IQuittable //step 3 //step 2 2nd drill
    {
        public int Id { get; set; }
        public override void SayName() //step 4
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit() 
        {
            Console.WriteLine("{0} {1} Quits", FirstName, LastName);
        }
    }
}
