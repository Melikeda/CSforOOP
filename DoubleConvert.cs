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
            double n1;
            Console.Write("Enter the number: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(n1);

            Console.Read();
        }
    }
} 
