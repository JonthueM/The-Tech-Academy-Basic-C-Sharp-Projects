using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace step182_IQuit
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string fullName = $"{firstName} {lastName} ";
            Console.WriteLine(fullName);
        }
        public void Quit()
        {
            string iQuit = "has Quit";
            Console.WriteLine(iQuit);
        }
    }
}
