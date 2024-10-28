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
            int n1,n2, avg;
            Console.Write("Number1: ");
            n1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Number2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            avg = (n1 + n2) / 2;
            Console.Write("Averange:" + avg);

            if(avg <= 49)
            {
                Console.Write(" Situation: Vasat");
            }
            if(avg >= 50 & avg <=70)
            {
                Console.Write(" Situation: Good");
            }
            if (avg >=70 & avg  <= 100)
            {
                Console.Write(" Situation: Perfect");
            }


            Console.Read();
        }
    }
} 