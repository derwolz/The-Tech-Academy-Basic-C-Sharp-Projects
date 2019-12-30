using System;

namespace DailyReportforStudents
{
    class Program
    {
        static void Main() 
        {
            
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What Course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What Page are you on?");
            int currentPage = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? (true/false)");
            bool parseHelp = bool.Parse(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An instructor will contact you shortly. Have a great day!");
            Console.Read();
            
               

        }
    }
}
