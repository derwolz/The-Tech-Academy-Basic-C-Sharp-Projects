using System;

namespace Abstract_p124
{
    class Program
    {
        static void Main(string[] args)
        {
            Person sample = new Employee() { FirstName = "Sample", LastName = "Student", Id = 0 };
            sample.SayName(); // step 5
            Console.ReadLine();
            IQuittable sample2 = new Employee() { FirstName = "Sample_2", LastName = "Student_2" };
            sample2.Quit();
        }
    }
}
