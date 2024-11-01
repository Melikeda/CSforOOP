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
            int[] number = { 120, 20, 0, 40, 660, 7 };
            Array.Sort(number);

            for (int i = 0; i <number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.Read();
        }
    }
}