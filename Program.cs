using System;

class Scope   // değişken kapsamını (scope) ve statik değişkenlerin kullanımı ile yerel değişkenlerin (local variable) nasıl çalıştığını anltamaktatır. 
{
    private static int x = 1;  //  Bu, sınıf düzeyinde tanımlı bir statik değişken. Tüm sınıf için ortaktır ve değeri metotlar arasında paylaşılır.

    static void Main()
    {
        int x = 5;  // Bu, Main metodu içinde tanımlanan yerel bir değişken. Sadece Main metodu içinde geçerlidir.
        Console.WriteLine("Local x in method Main is" + " " + x );

        UseLocalVariable();  //Metot içindeki işlemler yalnızca bu yerel x üzerinde çalışır ve dışarıdaki x'i etkilemez.

        UseStaticVariable();   // Tüm sınıfta ortak olduğu için diğer metotlar çağrıldığında bu değişiklikler etkili olur.

        Console.WriteLine("Local x in method Main is" + " " + x);
    }

    static void UseLocalVariable()
    {
        int x = 25;  // UseLocalVariable metodu içinde tanımlanan başka bir yerel değişken. Her metotta aynı ada sahip olmasına rağmen, birbirinden bağımsızdırlar.

        Console.WriteLine("Local x on entering method UseLocalVariable is" + " " + x);

        ++x;

        Console.WriteLine("Local x before exiting method UseLocalVariable is" + " " + x);
    }

    static void UseStaticVariable()
    {
 
        Console.WriteLine("Static x on entering method UseStaticVariable is" + " " + x);

        x *= 10;

        Console.WriteLine("Static x before exiting method UseStaticVariable is" + " " + x);
    }


}