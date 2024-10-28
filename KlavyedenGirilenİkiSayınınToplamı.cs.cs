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
            int n1, n2, sum;
            Console.Write("Enter the n1: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());
            sum = n1 + n2;
            Console.Write(sum);

            Console.Read();
        }
    }
} 
