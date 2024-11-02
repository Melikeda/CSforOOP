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
            PapaganClass p = new PapaganClass();
            p.tur = "Papağan";
            p.hiz = 50;
            p.isim = "Sultan";
            p.renk = "Sarı-Pempe";
            p.ses = "cikcok";
            p.agırlik = 1300;

            Console.WriteLine("İsim: " + p.isim);
            Console.WriteLine("Hiz: " + p.hiz);
            Console.WriteLine("Tür: " + p.tur);
            Console.WriteLine("Renk: " + p.renk);
            Console.WriteLine("Ses: " + p.ses);
            Console.WriteLine("Ağırlık: " + p.agırlik);

            Console.ReadLine();
        }

    }
}