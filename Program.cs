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
        static void Main(string[] args)
        {
            string[] city = new string[5]; //Klavyeden veri girişi olduğunda

            for(int i= 0; i < 5; i++)
            {
                Console.Write(" City name: ");
                city[i] = Console.ReadLine();
            }

            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine(city[j]);
            }

            Console.Read();
        }
    }
}