using System;

namespace CarInsuranceValidation
{
    class Program
    {
        static void Main()
        {
            bool DUI = false;
            bool ageCheck;
            bool duiCheck;
            bool ticketCheck;
            bool step2 = false;
            string result = null;
            
            Console.WriteLine("This will ask you some questions to validate Driving history");
            Console.WriteLine("What is your age");
            int age = Int32.Parse(Console.ReadLine());
            while (step2 == false)
            {
                Console.WriteLine("Have you ever had a DUI(Y/N)");
                string DUICheck = Console.ReadLine();
                if (DUICheck.ToLower() == "y")
                {
                    DUI = true;
                    step2 = true;
                }
                else if (DUICheck.ToLower() == "n")
                {
                    DUI = false;
                    step2 = true;
                }
                else
                {
                    Console.WriteLine("Answer must be (Y/N)");
                }
            }
            Console.WriteLine("How Many speeding tickets do you have?");
            int tickets = Int32.Parse(Console.ReadLine());
            if (age >= 15)
                ageCheck = true;
            else
                ageCheck = false;
            if (DUI == false)
                duiCheck = false;
            else
                duiCheck = true;
            if (tickets <= 3)
                ticketCheck = false;
            else
                ticketCheck = true;
            if (ageCheck == false)
                result += "Applicant is under 15. ";
            if (duiCheck == true)
                result += "Applicant has had a DUI. ";
            if (ticketCheck == true)
                result += $"Applicant has had {tickets} tickets";

            if (ageCheck && !duiCheck && !ticketCheck)
                Console.WriteLine("Applicant is Qualified");
            else
                Console.WriteLine($"Applicant has been rejected for the following reasons: {result}");





        }
    }
}
