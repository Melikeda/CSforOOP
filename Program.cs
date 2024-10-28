using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string country, city;
            Console.Write("Please enter the country: ");
            country = Console.ReadLine(); //Klavyeden alınan değerin hafıza tutulması
            Console.Write("Please enter the city: ");
            city = Console.ReadLine();
            Console.WriteLine(country + " " + city);

            Console.Read();
        }
    }
} 