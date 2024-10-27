using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, depertmant, classs;
            name = "Melike";
            surname = "Kulahci";
            depertmant = "Computer Engineering";
            classs = "Object Oriented Programming";

            int n1, n2, averange;
            n1 = 70;
            n2 = 65;
            averange = (n1 + n2) / 2;

            Console.WriteLine("***OBS***");
            Console.WriteLine();
            Console.WriteLine("Name and Surname:" + name + " " + surname);
            Console.WriteLine("Depertmant:" + depertmant);
            Console.WriteLine("Class:" + classs);
            Console.WriteLine();
            Console.WriteLine("Note1:" + n1);
            Console.WriteLine("Note2:" + n2);
            Console.WriteLine("Averange:" + averange);

            Console.Read(); 
        }
    }
}