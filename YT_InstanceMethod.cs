using System;

namespace MethodsTutorial
{
 class Program
 {
  static void Main()
  {
   Program program = new Program();   //Program sınıfından bir nesne (object) oluşturma işlemini yapıyor.
   int sonuc = program.Sum(11,22);
   Console.WriteLine("Sonuç: " + sonuc);
  }

  private int Sum(int a, int b)  // Instance method kısmı. Metod static değil, yani sınıfa doğrudan bağlı değil. Çalıştırmak için sınıftan bir nesne oluşturmanız gerekiyor.
  {
   return a + b;
  }
  
 } 
}  

 
