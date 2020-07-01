using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step166_TheVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loading the Class
            theVoid blackHole = new theVoid();

            //Prompt & Store
            Console.WriteLine("Random Number Please!");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Another One!");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            //Send, Receive & Print
            Console.WriteLine($"You typed {numberOne} x {numberTwo} = ");
            theVoid.voidOp(numberOne, numberTwo);



            //Keeps it Up
            Console.ReadLine();

        }
    }
}
