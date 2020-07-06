using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step187_OperatorOverload
{
    public class Employee : Person

    {
        public int ID { get; set; }
        public override void SayName()
        {
            string fullName = $"{firstName} {lastName} ";
            Console.WriteLine(fullName);
        }
        public static bool operator == (Employee employeeOne, Employee employeeTwo)
        {
            bool status = false;
            if (employeeOne.ID == employeeTwo.ID)
            { status = true; }
            
            return status;
             
        }
        public static bool operator != (Employee employeeOne, Employee employeeTwo)
        {
            bool status = false;
            if(employeeOne.ID != employeeTwo.ID) 
            { status = false; }
            return status;
        }
        


    }
}
