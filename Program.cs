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
            int number1, number2, sum;

            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine("Sum is" + " "+ sum); //
            Console.WriteLine();
            Console.WriteLine($"Sum is {sum}"); // string interpolation

        }

    }
}
