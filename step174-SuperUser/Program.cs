using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step174_SuperUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hourly = new Employee();
            hourly.FirstName = "Sample";
            hourly.LastName = "Student";
            hourly.SayName();

            Console.ReadLine();
           


        }
    }
}
