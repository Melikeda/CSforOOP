using System;

class Account
{
    private string name;

    public void SetName(string accountName) // Isim atama metodu (Setter)
    {
        name = accountName;
    }

    public string GetName() // Ismi okuma metodu (Getter)
    {
        return name;
    }
}

class AccountTest
{
    static void Main()
    {
        Account myAccount = new Account();  // Account sınıfından yeni bir nesne (object) türetme

        Console.WriteLine($"Initial name is: {myAccount.GetName()}");

        Console.Write("Enter the name: ");
        string theName = Console.ReadLine();

        myAccount.SetName(theName);

        Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
    }
}
