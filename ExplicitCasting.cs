using System;           // Explicit Casting (Açık Dönüştürme): Veri kaybı riski varsa veya türler uyumsuzsa, dönüştürme programcı tarafından açıkça yapılır.

namespace MyApplication
{
  class Program
  {
    static void Main()
    {
      double myDouble = 9.78;
      int myInt = (int) myDouble;  // Manual casting: double to int

      Console.WriteLine(myDouble);  // output 9.78 - 9
      Console.WriteLine(myInt);
    }
  }
}
