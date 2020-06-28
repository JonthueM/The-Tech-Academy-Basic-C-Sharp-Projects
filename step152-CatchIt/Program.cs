using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step152_CatchIt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> divideThis = new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            try
            {
                Console.WriteLine("Help me divide a list of numbers by giving me a number to divide with below!");
                int divideWith = Convert.ToInt32(Console.ReadLine());
                for (int everything = 0; everything < divideThis.Count; everything++)
                {
                    int sum = divideThis[everything] / divideWith;
                    Console.WriteLine($"{divideThis[everything]} / {divideWith} = {sum}");
                }


            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
