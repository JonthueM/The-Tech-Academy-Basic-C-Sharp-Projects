using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step182_IQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable iQuite = new Employee() { firstName = "Jonthue", lastName = "Michel" };
            
              iQuite.Quit();
            Console.ReadLine();

        }
    }
}
