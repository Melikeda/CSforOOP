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
            CarClass car = new CarClass(); //Sınıd adı  Nesne = new Sınıf adı şeklinde
            car.marka = "BMW";
            car.model = "2024";
            car.hiz = 300;
            car.motor = 1.8;
            car.renk = "Black";

            Console.WriteLine("Marka: " + car.marka);
            Console.WriteLine("Model: " + car.model);
            Console.WriteLine("Hız: " + car.hiz);
            Console.WriteLine("Motor: " + car.motor);
            Console.WriteLine("Renk: " + car.renk);

            Console.ReadLine();

        }

    }
}
