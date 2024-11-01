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
            int[] number = { 10, 20, 30, 40, 50, 60, 70 };

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] % 20 == 0 || number[i] % 30 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }

            Console.Read();
        }
    }
}