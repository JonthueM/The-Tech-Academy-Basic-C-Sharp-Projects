 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step161_3Deep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number below that you like to be multiplied 3x's");
            int chosenOne = Convert.ToInt32(Console.ReadLine());

            //Processing through 3 Operataions
            Operations mathOperator = new Operations();
            
            int finalSum = Operations.operationThree(Operations.operationTwo(Operations.operationOne(chosenOne)));
            
            Console.WriteLine($"\nYour number {chosenOne} X 3 X 30 x 300 = {finalSum} ");
            Console.ReadLine();


        }
    }
}
