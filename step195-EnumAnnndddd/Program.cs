 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step195_EnumAnnndddd
{
    class Program
    {
        static void Main(string[] args)
        {
            days days = new days();
            DaysOfTheWeek daysOfTheWeek = DaysOfTheWeek.Wedensday;

            String currentDay ="";
                             
                       
            try
            {
                Console.WriteLine("Enter Current Day of Week");
                currentDay = Console.ReadLine();
                DaysOfTheWeek daysOfTheWeek1 = (DaysOfTheWeek)System.Enum.Parse(typeof(DaysOfTheWeek), currentDay);
                Console.WriteLine(daysOfTheWeek1);
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            Console.ReadLine();


        }
    }
}
