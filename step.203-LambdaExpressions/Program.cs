using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step._203_LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string columHeader = "First Name: Last Name: ID:";
            Console.WriteLine("Not Using Lambda & Displaying New List that Holds Only Joe \n \n");
            //Creates New Batch List
            List<Person> tenEmployee = new List<Person>
            {
                new Person { firstName = "Luke", lastName = "SkyWalker", ID = 1 },
                new Person { firstName = "Fat", lastName = "Joe", ID = 2 },
                new Person { firstName = "Clark", lastName = "Cant", ID = 3 },
                new Person { firstName = "Tom", lastName = " Clancy", ID = 4},
                new Person { firstName = "Mighty", lastName = "Mouse", ID = 5 },
                new Person { firstName = "Donald", lastName = "Duck", ID = 6 },
                new Person { firstName = "John", lastName = "117", ID = 7 },
                new Person { firstName = "The", lastName = "Rock", ID = 8 },
                new Person { firstName = "Joe", lastName = "Ketchup", ID = 9 },
                new Person { firstName = "Joe", lastName = "Cain", ID = 10 }
            };
            //Created a new list to transfer later on
            List<Person> twoJoe = new List<Person>();

            //Transfer Joe to New List
            foreach (Person person in tenEmployee)
            {
                if (person.firstName == "Joe" ) 
                {

                    twoJoe.Add(person);
                }
            }
            //Displays Content
            Console.WriteLine(columHeader);
            foreach (Person person1 in twoJoe)
            {
                Console.WriteLine($"{person1.firstName}        {person1.lastName}       {person1.ID}");
                
            }
            Console.WriteLine("\n \nUsing Lambda & Displaying New List that Holds Only Joe \n \n");
            //Second BatchList
            List<Person> tenEmployee2 = new List<Person>
            {
                new Person { firstName = "Luke", lastName = "SkyWalker", ID = 1 },
                new Person { firstName = "Fat", lastName = "Joe", ID = 2 },
                new Person { firstName = "Clark", lastName = "Cant", ID = 3 },
                new Person { firstName = "Tom", lastName = "Clancy", ID = 4},
                new Person { firstName = "Mighty", lastName = "Mouse", ID = 5 },
                new Person { firstName = "Donald", lastName = "Duck", ID = 6 },
                new Person { firstName = "John", lastName = "117", ID = 7 },
                new Person { firstName = "The", lastName = "Rock", ID = 8 },
                new Person { firstName = "Joe", lastName = "Ketchup", ID = 9 },
                new Person { firstName = "Joe", lastName = "Cain", ID = 10 }
            };
            
            //Creates & Transfer using Lambda Expressions
            List<Person> joeList = tenEmployee2.Where(x => x.firstName == "Joe").ToList();
            //Prints the results the Console
            Console.WriteLine(columHeader);
            foreach (Person person3 in joeList)
            {
                Console.WriteLine($" {person3.firstName}       {person3.lastName}       {person3.ID} ");
                
            }

            Console.WriteLine("\n \nUsing Lambda & Displaying ID that are less then 005 \n \n");

            //Third BatchList
            List<Person> tenEmployee3 = new List<Person>
            {
                new Person { firstName = "Luke", lastName = "SkyWalker", ID = 1 },
                new Person { firstName = "Fat", lastName = " Joe", ID = 2 },
                new Person { firstName = "Clark", lastName = "Cant", ID = 3 },
                new Person { firstName = "Tom", lastName = "Clancy", ID = 4},
                new Person { firstName = "Mighty", lastName = "Mouse", ID = 5 },
                new Person { firstName = "Donald", lastName = "Duck", ID = 6 },
                new Person { firstName = "John", lastName = "117", ID = 7 },
                new Person { firstName = "The", lastName = "Rock", ID = 8 },
                new Person { firstName = "Joe", lastName = "Ketchup", ID = 9 },
                new Person { firstName = "Joe", lastName = "Cain", ID = 10 }
            };

            //Creates & Transfer using Lambda Expressions
            List<Person> filterID = tenEmployee3.Where(x => x.ID < g5).ToList();
            //Prints the results the Console
            Console.WriteLine(columHeader);
            foreach (Person person4 in filterID)
            {
                Console.WriteLine($" {person4.firstName}       {person4.lastName}       {person4.ID} ");

            }
            Console.ReadLine();        }
    }
}
