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
            int number;
            Random ran = new Random();
            number = ran.Next(0, 51);  //Birinci sayı random yazılabilir ama ikinci say yazılmaz

            Console.WriteLine(number);

            Console.ReadLine();
        }

    }
}
