using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step187_OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee hourlyOne = new Employee() {firstName = "Taco", lastName = "Bell", ID = 7171 };
            Employee hourlyTwo = new Employee() { firstName = "Dunkin", lastName = "Donuts", ID = 7171 };
            if (hourlyOne.ID == hourlyTwo.ID)
            {
                Console.WriteLine("OMG Their's a Match. I think we should alert the devs of this bug ASAP!");
                    
             }
            else { Console.WriteLine("I told you that their isn't a problem with our system"); }

            if (hourlyOne.ID == hourlyTwo.ID)
            {
                Console.WriteLine("I told you that their isn't a problem with our system");
            }
            else
            { Console.WriteLine("Don't rub it in!"); }

            Console.ReadLine();
            

        }
    }
}
