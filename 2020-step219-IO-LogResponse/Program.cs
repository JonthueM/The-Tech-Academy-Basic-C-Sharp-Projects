using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step219_IO_LogResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path
            string path = @"C:\Users\conne\Documents\log-210.txt";

            //Insert & Store
            Console.WriteLine("Hello There! Please insert a random number below");
            string randomNumber = Console.ReadLine();

            //Write to Path 
            File.WriteAllText(path, randomNumber);
            Console.WriteLine("Retreiving from Written File");

            //Read From Path
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

            Console.ReadLine();

        }
    }
}
