using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_step225_CatchThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old Are You This Year?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            if (age >0)
            {
                int birthYear = age - 2020;
                Console.WriteLine(birthYear);
            }
        

            try
            {
                if (age == 0)
                {
                    throw new ArgumentException("Please No Zero's");

                }
                
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Please No Zero's");
            }
            try
            {
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException("Why So Negative");
                }
                
            }
            catch (ArgumentOutOfRangeException i)
            {
                Console.WriteLine("Why So Negative");
            }
            
            

            Console.ReadLine();
        }
    }
}
