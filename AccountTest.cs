using System;  //bu satır olmadan Console.WriteLine ve diğer metotlar çalışmaz

class AccountTest  //AccountTest adında bir sınıf tanımlar. Sınıf, C#’ta kodun düzenlendiği ve metodların içinde çalıştığı yapıdır.
{
  static void Main() 
  {
    Account myAccount = new Account();   //Account sınıfından bir nesne oluşturur. new anahtar kelimesi, bellekte yeni bir Account nesnesi yaratır. Oluşturulan nesne myAccount değişkenine atanır.
                                         //Artık myAccount değişkeni üzerinden Account sınıfının metodlarına ve özelliklerine erişebiliriz.
    Console.WriteLine($"Initial name is: {myAccount.GetName()}");  //myAccount.GetName() metodu çağrılıyor. Bu metod, myAccount nesnesinde saklanan ad bilgisini döndürür.

    Console.write("Enter the name: ");

    string theName = Console.ReadLine();

    myAccount.SetName(theName);  //Kullanıcının girdiği tam satırı okur ve theName değişkenine atar. SetName metodunun amacı, bir Account nesnesinin içindeki hesap adını değiştirmek veya atamaktır.

    Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");

  }
}  
