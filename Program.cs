using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string city;
            Console.Write("City name: ");
            city = Console.ReadLine();

            if(city == "Erzurum")
            {
                Console.Write("True city");
            }
            else
            {
                Console.Write("False city");
            }


            Console.Read();
        }
    }
} 