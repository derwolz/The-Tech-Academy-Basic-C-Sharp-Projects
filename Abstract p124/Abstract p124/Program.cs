using System;

namespace Abstract_p124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> sample = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 0 };
            sample.SayName(); // step 5
            Console.ReadLine();
            Employee<int> sample2 = new Employee<int>() { FirstName = "Sample_2", LastName = "Student_2", Id = 0};
            Random rand = new Random(); // used to create items to add to the list
            for (int x= 0; x < 12; x++) // Add Items to the list
            {
                sample2.Things.Add(rand.Next(0, 50));
                string item = "The Number " + rand.Next(0, 26).ToString();
                sample.Things.Add(item);
            }
            for (int x = 0; x < 12; x++) // Display Items
            {
                Console.WriteLine("Sample 2 Item {0} : {1}", x + 1, sample2.Things[x]);
                Console.WriteLine("Sample 1 Item {0} : {1}", x + 1, sample.Things[x]);
            }
            //Console.WriteLine(sample == sample2);
            
        }
    }
}


