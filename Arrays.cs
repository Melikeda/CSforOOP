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
            string[] city = { "Ankara", "Çorum", "Trabzon", "Diyarbakır" };
            int[] number = { 1, 2, 3, 4 };

            Console.WriteLine(city[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine();

            for (int i= 0; i<=3; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.Read();
        }
    }
}
