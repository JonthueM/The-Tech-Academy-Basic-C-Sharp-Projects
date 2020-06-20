using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step117_ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts & Starting Variable
            Console.WriteLine("Welcome to Package Weight. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package Width:");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            int Length = Convert.ToInt32(Console.ReadLine());

            //Calculations
            int Dimensions = Width + Height + Length;
            int Results = Dimensions * Weight / 100;
            

            ///Branching
           if (Weight < 50 & Dimensions < 50)
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + Results);
                Console.WriteLine("Thank you.");
            }
           else if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
           else if (Dimensions> 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.  Have a good day.");
            }

            Console.ReadLine();
        }
    }
}
