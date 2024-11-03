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
            TimeSpan zaman;
            int gunfarki;
            DateTime  tarih1, tarih2;
            tarih1 = Convert.ToDateTime("01.03.2002");
            tarih2 = Convert.ToDateTime("03.11.2024");
            zaman = tarih2 - tarih1;
            gunfarki = zaman.Days;

            Console.WriteLine("Gün Farkı: " + gunfarki);

            Console.ReadLine();
        }

    }
}
