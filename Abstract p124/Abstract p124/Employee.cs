using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_p124
{
    public class Employee<T> : Person, IQuittable //step 3 //step 2 2nd drill
    {
        public int Id { get; set; }
        public List<T> Things = new List<T>();

        public override void SayName() //step 4
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit() 
        {
            Console.WriteLine("{0} {1} Quits", FirstName, LastName);
        }
        public static bool operator == (Employee<T> employee, Employee<T> employee2)
        {
            bool isTrue = employee.Id == employee2.Id;
            return isTrue;
        }
        public static bool operator!= (Employee<T> employee, Employee<T> employee2)
        {
            bool isTrue = employee.Id != employee2.Id;
            return isTrue;
        }
        public override bool Equals(Object o)
        {
            bool isTrue = this.Id == o.GetHashCode();
            return isTrue;
        }
        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}
