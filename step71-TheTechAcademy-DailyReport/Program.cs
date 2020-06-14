using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step71_TheTechAcademy_DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title & Subtitle
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //Questions
            Console.WriteLine("What is your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseYourOn = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int todayPageNumber = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            string askHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(askHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string todayExperience = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int totalHours = Convert.ToInt32(hours);


            //Final Response
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
