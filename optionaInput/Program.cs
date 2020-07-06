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
            int ranNumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Would You Like To Enter A Second Number? Currently it is {ranNumOne} X 10.  Please Type Y or N Below!");
            string fate = Console.ReadLine();
            int ranNumTwo;
            
            if (fate == "Y")
            {
                Console.WriteLine("Please Enter A Second Random Number to replace 10 Below!");
                ranNumTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You typed {ranNumOne} to be multplied by {ranNumTwo} and your results are:");
                int results = optionalOperation.optionalOps(ranNumOne, ranNumTwo);
                Console.WriteLine(results);
            }
            else 
            {
                Console.WriteLine("Okie Dokie! The Results Are:");
                int results = optionalOperation.optionalOps(ranNumOne);
                Console.WriteLine(results);

            }
                    

            Console.ReadLine();

        }
    }
}
