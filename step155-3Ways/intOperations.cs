using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step155_3Ways
{
    class intOperations
    {
        public static int manyToOne(int firstNumber) 
        {
            return firstNumber * 10;
        }
        public static decimal manyToOne(decimal secondNumber) 
        {
            return secondNumber + 10050;
        }
        public static string manyToOne(string thirdNumber, out int output) 
        {
            int converted = Convert.ToInt32(thirdNumber);
            int takeThis = converted / 5;
            output = takeThis;
            return thirdNumber;

        }
    }
}
