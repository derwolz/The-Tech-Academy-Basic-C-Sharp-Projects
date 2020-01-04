using System;

namespace Abstract_p124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student", Id = 0 };
            sample.SayName(); // step 5
            Console.ReadLine();
            Employee sample2 = new Employee() { FirstName = "Sample_2", LastName = "Student_2", Id = 0};
            
            Console.WriteLine( sample == sample2);
            
        }
    }
}


