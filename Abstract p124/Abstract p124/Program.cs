using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_p124
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Roster employeeroster = new Roster(); //New Class Roster Created to handle List creation
            Console.WriteLine(employeeroster.Employees.Count);
            List<Employee> Joes = new List<Employee>();
            foreach (Employee employee in employeeroster.Employees)
            {
                if (employee.FirstName == "Joe")
                    Joes.Add(employee);
            }
            Console.WriteLine(Joes.Count);


            Console.WriteLine("This is with Lambda"); // find number of Joes in list
            List<Employee> newRoster = employeeroster.Employees.Where(x => x.FirstName.Contains("Joe")).ToList();
            Console.WriteLine(Joes.Count);

            List<Employee> new2Roster = employeeroster.Employees.Where(id => id.Id > 5).ToList();
            foreach (Employee employee in new2Roster) //.............................................List names of those with an Id > 5
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            
            //for (int x = 0; x < 12; x++) // Display Items
            //{
            //    Console.WriteLine("Sample 2 Item {0} : {1}", x + 1, sample2.Things[x]);
            //    Console.WriteLine("Sample 1 Item {0} : {1}", x + 1, sample.Things[x]);
            //}
            //Console.WriteLine(sample == sample2);
            
        }
    }
}


