using System;

// 1. Şablon Sınıf (Constructor YOK)
class Account
{
    // Sadece varsayılan (boş) bir property var
    public string Name { get; set; }
}

// 2. Çalıştırıcı Sınıf
class AccountTest
{
    static void Main()
    {
        // Adım 1: Nesne önce içi boş (Name = null) olarak oluşturulur
        Account account1 = new Account();

        // Adım 2: Değer sonradan ayrı bir satırda atanır
        account1.Name = "Jane Green";

        // Değeri ekrana yazdırma
        Console.WriteLine($"account1 name is: {account1.Name}");
    }
}
