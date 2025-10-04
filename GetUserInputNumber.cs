using System;

namespace MyApplication
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter your age:");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your age is: " + age);
    }
  }
}
