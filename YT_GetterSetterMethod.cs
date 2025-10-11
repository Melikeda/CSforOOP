using System;

class BankAccount
{
    private double balance; // private değişken, doğrudan erişilemez. bir instance değişken (field) tanımıdır

    // Getter Method kısmı: bakiyeyi al
    public double GetBalance()
    {
        return balance;
    }

    // Setter Method kısmı: bakiyeyi ayarla
    public void SetBalance(double amount)
    {
        if (amount >= 0) // negatif değer atamasına izin verme
        {
            balance = amount;
        }
        else
        {
            Console.WriteLine("Bakiyeniz negatif olamaz!");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.SetBalance(500); // setter ile bakiye ayarlandı
        Console.WriteLine("Hesap Bakiyesi: " + account.GetBalance()); // getter ile bakiyeyi aldık

        account.SetBalance(-100); // negatif değer denemesi
        Console.WriteLine("Hesap Bakiyesi: " + account.GetBalance());
    }
}
