using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step155_3Ways
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are many ways to reach the peak you seek!\n\n");
            Console.WriteLine("Chose a Number!");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chose a Number with a decimal");
            decimal two = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Chose a Number that you have not used before without a decimal");
            string three = Console.ReadLine();

            //Prcoessing
            int takeThis = 0;
            intOperations manytoOne = new intOperations();
            int returnValue1 = intOperations.manyToOne(one);
            decimal returnValue2 = intOperations.manyToOne(two);
            string pushValue = intOperations.manyToOne(three,out takeThis);
            Console.WriteLine($"\nPath One: Your Number {one} x 10 = {returnValue1}. \nPath Two: Your Decimal Value {two} + 10050 = {returnValue2}. \n Path Three: Your number {three} / 5 = {takeThis}");
            Console.ReadLine();
        }
    }
}
