using System;
using System.IO;
using System.Collections.Generic;
namespace TextLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give Me a Number");
            try
            {
                int numQuery = Int32.Parse(Console.ReadLine());
                using (StreamWriter file = new StreamWriter(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\TextLogger\\NumberLog.txt", true))
                {
                    file.WriteLine("number {0} added at {1},",numQuery.ToString(), DateTime.Now.ToString());
                }
            }
            catch (FormatException ex)
            {
                using (StreamWriter file2 = new StreamWriter(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\TextLogger\\log.txt", true))
                {
                    file2.WriteLine("{0} : {1}", DateTime.Now.ToString(), ex.Message);
                    Console.WriteLine("\nNumber was not entered, logging failed attempt");
                }
            }
            finally
            {
                using (StreamReader file3 = new StreamReader(@"C:\\Users\\Dr Sam Hyde\\source\\repos\\The-Tech-Academy-Basic-C-Sharp-Projects\\TextLogger\\NumberLog.txt"))
                {
                    List<string> displayText = new List<string>();
                    string text1 = file3.ReadToEnd();
                    displayText.AddRange(text1.Split(','));
                    foreach (string text in displayText)
                    {
                        Console.WriteLine(text);
                    }
                }
                Console.Read();
            }
        }
    }
}
