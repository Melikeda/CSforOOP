﻿using System;
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
            int bakteri = 1;
            for(int i=1; i<=24; i++)
            {
                bakteri = bakteri * 2;
                Console.WriteLine(bakteri);
            }
            Console.Read();
        }
    }
}
