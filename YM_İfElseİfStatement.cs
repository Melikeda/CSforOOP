/* if (koşul1)
   {
     koşul1 doğruysa yapılacak işlem
  }
  else if (koşul2)
  {
     koşul2 doğruysa yapılacak işlem
  }
  else
  {
     hiçbir koşul doğru değilse yapılacak işlem
  }
*/  
  

int grade = 85;

if (grade >= 90)
{
    Console.WriteLine("A");
}
else if (grade >= 80)
{
    Console.WriteLine("B");
}
else if (grade >= 70)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("D veya F");
}
