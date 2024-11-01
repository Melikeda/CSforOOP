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

        public static void numbers() 
        {
            for(int i = 0; i<=10; i++)
            {
                Console.Write(i + " ");
            }
        }


        static void Main(string[] args)
        {
            sumMethod();
            Console.WriteLine();
            numbers();

        }
    }
}