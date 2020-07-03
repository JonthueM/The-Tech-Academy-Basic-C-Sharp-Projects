using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step169_voidFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load the Class
            voidClass voidFactor = new voidClass();


            //Prompt & Store
            Console.WriteLine("Type a number that you want to be divided by 2");
            int number = Convert.ToInt32(Console.ReadLine());

            //Processing & Output
            int output = 0;
            voidClass.voidOp(number, out output);
            Console.WriteLine($"Your {number} / 2 =");
            voidFactor.voidOp(number);
            Console.WriteLine($"{number} / 2 =  {output}");
            Console.ReadLine();

        }
    }
}
