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
            int d1, d2, d3, d4;
            Random ran = new Random();
            d1 = ran.Next(0,10);
            d2 = ran.Next(0,10);
            d3 = ran.Next(0,10);
            d4 = ran.Next(0, 10);

            string[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E" };
            Console.WriteLine(d1 + karakterler[d2] + d3 + karakterler[d4]);

            Console.ReadLine();
        }

    }
}
