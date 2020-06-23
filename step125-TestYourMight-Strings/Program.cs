using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step125_TestYourMight_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There! You are going to help me with this assignment, so lets go.");
            Console.WriteLine("Give me a 3 word sentence, after the following prompt \n \n");


            Console.WriteLine("Prompt 1");
            string Prompt1 = Console.ReadLine();
            Console.WriteLine("Prompt 2");
            string Prompt2 = Console.ReadLine();
            Console.WriteLine("Prompt 3");
            string Prompt3 = Console.ReadLine();
            Console.WriteLine("\n");

            //Combine & Print
            string firstSentence = Prompt1 + " " + Prompt2 + " " + Prompt3 + "." + " \n";
            string returningResponse = "You typed \n" + firstSentence.ToUpper();
            Console.WriteLine(returningResponse + "Thank You! \n \n");

            //StringBuilder
            StringBuilder shortParagraph = new StringBuilder();
            shortParagraph.Append("You typed," + firstSentence + "I typed, You are Awesome! \nSomeone typed, This will pass.");
            Console.WriteLine(shortParagraph);

            Console.ReadLine();
        }
    }
}
