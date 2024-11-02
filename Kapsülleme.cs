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
            PeopleClass people = new PeopleClass();

            Console.Write("Enter the name: ");
            people.Ad = Console.ReadLine();  //Klavyeden griş yapmak için
            Console.Write("Enter the surname: ");
            people.Soyad = Console.ReadLine();
            Console.Write("Enter the id: ");
            people.id = Convert.ToInt16 (Console.ReadLine());
            Console.Write("Enter the city: ");
            people.sehir = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(people.ad + " - " + people.soyad + " " + people.id + " " + people.sehir);

            Console.ReadLine();

        }

    }
}
