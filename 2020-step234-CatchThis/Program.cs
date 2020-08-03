using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_step234_CatchThis
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("How Old Are You This Year?");
                int age;
                age = Convert.ToInt32(Console.ReadLine());

                if (age == 0)
                {
                    throw new Exception("Please No Zero's");
                }
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException("Why So Negative");
                }

                int birthYear = age - 2020;
                Console.WriteLine(birthYear);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Why So Negative");
            }
            catch (Exception)
            {
                Console.WriteLine("Please No Zero's");
            }
            
            finally
            {
                Console.WriteLine("Not Valid");
            }
            
            
            









            Console.ReadLine();
        }
    }
}
