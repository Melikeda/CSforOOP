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
            byte plate;
            Console.Write("Enter the license plate: ");
            plate = byte.Parse(Console.ReadLine());

            switch (plate)
            {
                case 19:
                    Console.WriteLine("Hello Çorum");
                    break;
                case 34:
                    Console.WriteLine("Hi İstanbul");
                        break;
                case 35:
                    Console.WriteLine("Hi There İzmir");
                    break;
                default:
                    Console.WriteLine("There is no this city");
                    break;

            }

            Console.Read();
        }

    }
}
