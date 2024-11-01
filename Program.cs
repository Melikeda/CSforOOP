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
            int n1, n2, result;
            Console.Write("Enter the n1: ");
            n1 = Convert.ToInt16 (Console.ReadLine());
            Console.Write("Enter the n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Result: " + Sum(n1, n2));

            Console.Read();
        }

    }
}