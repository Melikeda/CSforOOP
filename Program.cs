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
            double number;
            Console.Write("Enter the number: ");
            number = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Mutlak Değer: " + Math.Abs(number));

            Console.ReadLine();
        }

    }
}