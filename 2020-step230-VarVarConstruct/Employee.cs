using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_step221_VarVarConstruct
{
    class Employee : Person
    {
        public string department { get; set; }

        //Example of Construct Chaining
        public Employee(string name, int ID, string department)
        {
            Console.WriteLine($"{name} {ID} {department}");


        }

        public Employee(string name, int ID)
            : this(name, ID, "Tech")
        {
            Console.WriteLine($"{name} {ID}");
        }

        public Employee(string name)
            : this(name, 191, "Tech")
        {

            Console.WriteLine($"{name}");
        }
    }
}
