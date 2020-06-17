using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step100_CarInsurranceBasicApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Questions, Starting Variables & Print
            Console.WriteLine("What is your age?");
            string ageCollect = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? True or False");
            string questionCollect = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsRecordCollect = Console.ReadLine();


            //Conversion
            int age = Convert.ToInt32(ageCollect);
            int tickets = Convert.ToInt32(ticketsRecordCollect);

            //Process
            bool qualifyingFactor = ( age >= 15 && questionCollect == "False" && tickets < 3);

            //Output
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualifyingFactor);

            //Keep It Up
            Console.ReadLine();
        }
    }
}
