using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step210_IO_LogResponse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Path
            string path = @"C:\Users\conne\Documents\log-210.txt";
            Console.WriteLine("Hello There! Please insert a random number below");
            string randomNumber = Console.ReadLine();
            File.WriteAllText(path, randomNumber);
            Console.WriteLine("Retreiving from Written File");
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

            Console.ReadLine();

        }
    }
}
