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
        public static void sumMethod()   
        {
            int n1, n2, sum;
            n1 = 35;
            n2 = 3;
            sum = n1 + n2;
            
           Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            sumMethod();
            
        }
    }
}