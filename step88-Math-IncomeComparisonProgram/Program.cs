using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step88_Math_IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Title
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person One Request And Conversion 
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string personOneHourly = Console.ReadLine();
            int pOneHourly = Convert.ToInt32(personOneHourly);
            Console.WriteLine("Hours worked per week?");
            string personOneHours = Console.ReadLine();
            int pOnePayPerHour = Convert.ToInt32(personOneHours);

            
            // Person Two Request and Conversion
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string personTwoHourly = Console.ReadLine();
            int pTwoHourly = Convert.ToInt32(personTwoHourly);
            Console.WriteLine("Hours worked per week?");
            string personTwoHours = Console.ReadLine();
            int pTwoPayPerHour = Convert.ToInt32(personOneHours);

            //Person One Calculations
            decimal totalHoursOne = pOneHourly * 52;
            decimal annualIncomeOne = totalHoursOne * pOnePayPerHour;

            //Person Two Calculations
            decimal totalHoursTwo = pTwoHourly * 52;
            decimal annualIncomeTwo = totalHoursTwo * pTwoPayPerHour;

            //Person One & Two Annual Comparison
            bool comparison = annualIncomeOne > annualIncomeTwo;

            //Output Annual Incomes & Comparison Results
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualIncomeOne);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualIncomeTwo);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(comparison);

            //Keep it Open
            Console.ReadLine();
        }
    }
}
