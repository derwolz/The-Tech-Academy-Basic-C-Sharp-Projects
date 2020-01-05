using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Abstract_p124
{
    class Roster
    {
        List<string> firstName = new List<string>()
            {
                "Tiffany", "Spencer", "Joe", "Joe", "William",
                "Jared", "Billy", "Jessica", "Joel", "Jodi"
            };
        List<string> lastName = new List<string>()
            {
                "Appleman", "Pearman", "Hoover", "Smith", "Goldman",
                "Hosman", "Browski", "LastName", "Feldman", "Wally"
            };
        public List<Employee> Employees = new List<Employee>();
        public Roster() 
        {
            

            for (int i = 0; i < firstName.Count; i++)
            {
                Employee employee = new Employee();
                employee.FirstName = firstName[i];
                employee.LastName = lastName[i];
                employee.Id = i;
                this.Employees.Add(employee);
            } 
            
        }
        

    }
}

