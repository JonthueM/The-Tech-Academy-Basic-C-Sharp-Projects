using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step169_voidFactor
{
    class voidClass
    {
         public void voidOp(int numOne) { int sum = numOne / 2; Console.WriteLine(sum); }
        public static void voidOp(int numOne, out int output) { int sum = numOne / 2; output = sum; }


    }
}
