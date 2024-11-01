using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    class Program
    {
        public static void methods(string p) //Parametreyi klavyeden aldığında
        {
            Console.WriteLine("******");
            Console.WriteLine(p);
            Console.WriteLine("******");
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the Word: ");
            string word = Console.ReadLine();

            methods(word);
            Console.Read();
        }

    }
}