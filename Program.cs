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
            string metin1, metin2;
            Console.Write("Enter the metin1: ");
            metin1 = Console.ReadLine();
            Console.Write("Enter the metin2: ");
            metin2 = Console.ReadLine();
            Console.WriteLine("Concat ile birleştirme: " + string.Concat(metin1, metin2));

            Console.ReadLine();
        }

    }
}
