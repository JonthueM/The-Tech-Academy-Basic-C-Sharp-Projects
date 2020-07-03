using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step174_SuperUser
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() { string fullName = FirstName + " " + LastName; Console.WriteLine($"Name: {fullName}"); }

    }
}
