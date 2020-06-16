using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step88_Math_MultiplyToDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to be mutplied by 50?");
            string inputOne = Console.ReadLine();
            int multiply = Convert.ToInt32(inputOne);
            int multiplying  = multiply * 50;
            Console.WriteLine(multiplying);
           

            Console.WriteLine("What would you like to be added by 25?");
            string inputTwo = Console.ReadLine();
            int add = Convert.ToInt32(inputTwo);
            int adding = add + 25;
            Console.WriteLine(adding);
            

            Console.WriteLine("What would you like to be divided by 12.5?");
            string inputThree = Console.ReadLine();
            int divide = Convert.ToInt32(inputThree);
            decimal twelveFive = 12.5m;
            decimal dividing = divide / twelveFive;
            Console.WriteLine(dividing);

            Console.WriteLine("It is greater then 50? Type below!");
            string inputFour = Console.ReadLine();
            int greaterOrLess = Convert.ToInt32(inputFour);
            bool verdictOne = greaterOrLess > 50;
            Console.WriteLine(verdictOne);

            Console.WriteLine("What would you like to see divided and the reminder of 7");
            string inputFive = Console.ReadLine();
            int remainder = Convert.ToInt32(inputFive);
            int remainding = remainder % 7;
            Console.WriteLine(remainding);
            Console.ReadLine();


        }
    }
}
