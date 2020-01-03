using System;

namespace Inheritance_1_p_120
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 4
            employee sample = new employee { FirstName = "Sample", LastName = "Student", Id = 1 };
            sample.SayName(); //step 5
            Console.ReadLine();
        }
    }
}
