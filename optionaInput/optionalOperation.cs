using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionaInput
{
    class optionalOperation
    {
        public static int optionalOps(int numberOne, int numberTwo = 10) 
        {
            return numberOne * numberTwo;
        }
    }
}
