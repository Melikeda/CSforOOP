using System;

// ===================================================
// 1. ŞABLON SINIF (Fig. 4.11: Account.cs)
// ===================================================
class Account
{
    public string Name { get; set; }
    private decimal balance;

    // Constructor: İsim ve başlangıç bakiyesi alır
    public Account(string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance; // Sadece pozitifse bakiyeye aktarır
    }

    // Balance Property: Okunabilir (public get), dışarıdan direkt değiştirilemez (private set)
    public decimal Balance
    {
        get
        {
            return balance;
        }
        private set
        {
            if (value > 0.0m)
            {
                balance = value;
            }
        }
    }

    // Para yatırma metodu
    public void Deposit(decimal depositAmount)
    {
        if (depositAmount > 0.0m)
        {
            Balance = Balance + depositAmount;
        }
    }
}

// ===================================================
// 2. ÇALIŞTIRICI SINIF (Fig. 4.12: AccountTest.cs)
// ===================================================
class AccountTest
{
    static void Main()
    {
        // Adım 1: İki hesap nesnesi oluşturuluyor (biri pozitif, biri negatif bakiyeli)
        Account account1 = new Account("Jane Green", 50.00m);
        Account account2 = new Account("John Blue", -7.53m); // Negatif bakiye kabul edilmez, 0 kalır

        // Adım 2: İlk bakiyeleri ekrana yazdırma (:C para birimi formatıdır)
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        // Adım 3: account1 için kullanıcıdan para yatırma miktarı alma
        Console.Write("\nEnter deposit amount for account1: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
        account1.Deposit(depositAmount); // Hesaba parayı yatır

        // Güncel bakiyeleri tekrar gösterme
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        // Adım 4: account2 için kullanıcıdan para yatırma miktarı alma
        Console.Write("\nEnter deposit amount for account2: ");
        depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
        account2.Deposit(depositAmount); // Hesaba parayı yatır

        // Son bakiyeleri gösterme
        Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
        Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
    }
}
