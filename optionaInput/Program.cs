using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionaInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loading the Class
            optionalOperation simpleTask = new optionalOperation();

            //Prompt & Store
            Console.WriteLine("Enter A Random Number!");
            int randomNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Just Press Enter!");
            Console.ReadLine();
            //int optionalValue = Convert.ToInt32(Console.ReadLine());

            //Passing, Receiving & Printing
            int results = optionalOperation.optionalOps(randomNumber);
            Console.WriteLine(results);

            Console.ReadLine();

        }
    }
}
