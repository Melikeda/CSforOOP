using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number: ");
            number = Convert.ToInt16(Console.ReadLine());

            for(int i=1; i<=number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }

    }
}
