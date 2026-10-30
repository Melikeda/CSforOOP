using System;

// (Property Yoluyla Kapsülleme)
class Account
{
    private string name; // Gizli değişken (Instance variable)

    // Name Özelliği (Property)
    public string Name
    {
        get
        {
            return name; // Değeri okur
        }
        set
        {
            name = value; // Gelen değeri name değişkenine atar
        }
    }
}

// 2. Programın Çalıştırıldığı Sınıf
class AccountTest
{
    static void Main()
    {
        // Account sınıfından yeni bir nesne oluşturuluyor
        Account myAccount = new Account();

        // Başlangıç ismini get (okuma) bloğuyla ekrana yazdırma
        Console.WriteLine($"Initial name is: {myAccount.Name}");

        // Kullanıcıdan isim alma
        Console.Write("Please enter the name: ");
        string theName = Console.ReadLine();

        // Alınan ismi set (yazma) bloğu aracılığıyla aktarma
        myAccount.Name = theName;

        // Güncel ismi ekrana yazdırma
        Console.WriteLine($"myAccount's name is: {myAccount.Name}");
    }
}
