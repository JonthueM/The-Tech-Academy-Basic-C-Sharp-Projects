using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step190_GenericEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Playing with generic class & list \n");
            Employee <string> employee = new Employee<string>();
            employee.things = new List<string>() {"One","Two", "Three","Four","Five"};

            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>() { 1, 2, 3, 4, 5, };

            Console.WriteLine("String");
            for (int i = 0; i < employee.things.Count; i++)
            {
                Console.WriteLine(employee.things[i]);
            }

            Console.WriteLine("\n \nInt");
            for (int i=0; i<employee1.things.Count; i++)
            {
                Console.WriteLine(employee1.things[i]);
            }
            Console.ReadLine();
        }
    }
}
