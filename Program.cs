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
        public static int Sum(int n1, int n2) 
        {
            int result;
            result = n1 + n2;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sum: " + Sum(10, 20));
            Console.Read();
        }

    }
}