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
            string username, password;
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            if(username == "Admin" & password == "123456")
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }


            Console.Read();
        }
    }
} 