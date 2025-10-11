using System;

namespace MethodsTutorial
{
 class Program
 {
  static void Main()
  {
   int sonuc = carp(2, 6);  // static olduğu için nesne oluşturulmadan çağrılabilir.
   Console.WriteLine("Sonuç: " + sonuc);
  }

  static int carp(int x, int y)  //static method kısmı. 
  {
   return x * y;
  }
  
 } 
}  
