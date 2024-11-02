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
            people.ad = "Melike";
            people.soyad = "Külahcı";
            people.id = 1;
            people.sehir = "Düzce";


            Console.WriteLine("Ad: " + people.ad + " Soyad: " + people.soyad + " id: " + people.id + " Şehir: " + people.sehir);
            
            Console.ReadLine();

        }

    }
}
