using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello ";
            string word2 = "David";
            string word3 = "!";
            Console.WriteLine(word1 + word2 + word3);
            string word4 = "all of these are lower case.";
            Console.WriteLine(word4);
            Console.WriteLine("the last set will now be upper case");
            Console.WriteLine(word4.ToUpper());
            StringBuilder thisparagraph = new StringBuilder();
            thisparagraph.Append("This is the 1st sentence of the paragraph.");
            Console.WriteLine(thisparagraph);
            thisparagraph.Append("\n Now I have added a second line to the paragraph");
            Console.WriteLine(thisparagraph);
            thisparagraph.Append("\n Doesn't this work well?");
            Console.WriteLine(thisparagraph);
            Console.Read();
        }
    }
}
