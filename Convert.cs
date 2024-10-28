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
            int number;
            Console.Write("Enter the number: ");
            number = Convert.ToInt16(Console.ReadLine());  //Klavyeden girilen değerler stribg türünde olduğu için bunu int türüne çevirmeliyiz
            Console.Write(number);

            Console.Read();
        }
    }
} 
