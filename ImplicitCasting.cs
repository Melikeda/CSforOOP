using System;  // Implicit Casting (Örtük Dönüştürme): Küçük boyutlu bir veri türü, otomatik olarak daha büyük boyutlu bir veri türüne dönüştürülür.

namespace MyApplication
{
  class Program
  {
    static void Main()
    {
      int myInt = 9;
      double myDouble = myInt;  // Automatic casting: int to double

      Console.WriteLine(myInt);         // output 9 - 9
      Console.WriteLine(myDouble);
    }
  }
}
