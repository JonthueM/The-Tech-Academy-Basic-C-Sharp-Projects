using _2020_step221_VarVarConstruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2020_step230_VarVarConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var
            var y = 10;

            //Consruct Variable
            const int x = 10;

            Console.WriteLine($"{y} {x}");

            Employee name = new Employee("Jonthue");
            Employee nameID = new Employee("Runner", 0071);
            Employee nameIDdept = new Employee("WAREON", 9071, "Defense");


            Console.ReadLine();
            

            
        }
    }
}
