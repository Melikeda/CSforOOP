using System;

// 1. Şablon Sınıf (Constructor VAR)
class Account
{
    public string Name { get; set; }

    // Yapıcı Metod (Constructor)
    public Account(string accountName)
    {
        Name = accountName; // Gelen ismi ilk anda Name'e kaydeder
    }
}

// 2. Çalıştırıcı Sınıf
class AccountTest
{
    static void Main()
    {
        // Nesne oluşturulurken parantez içinde isim doğrudan gönderilir
        Account account1 = new Account("Jane Green");

        // Değeri ekrana yazdırma
        Console.WriteLine($"account1 name is: {account1.Name}");
    }
}
