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
        public static int Sum() 
        {
            int n1, n2, result;
            n1 = 67;
            n2 = 45;
            result = n1 + n2;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum());
            Console.Read();
        }

    }
}
