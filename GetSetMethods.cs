using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;


namespace ConsoleApp1
{
    class Account  //Account adlı bir sınıf tanımladık
    {
        // Özel bir alan (field) tanımlıyoruz
        private string name;  //private: Bu alanın sadece bu sınıfın içinde erişilebilir olduğunu belirtir.
                              //string name: Hesapla ilgili bir isim tutmak için bir metin (string) değişken tanımlanır.


        // Getter metodu: 'name' alanının değerini döndürür
        public string GetName()  //public: Bu metot, sınıfın dışından çağrılabilir. 
                                 //GetName: name değişkeninin değerini döndüren bir metot
        {
            return name;   //return name;: name alanının mevcut değerini döndürür
        }

        // Setter metodu: 'name' alanına bir değer atar
        public void SetName(string newName)    //public: Bu metot, sınıfın dışından çağrılabilir
                                               //void: Bu metot bir değer döndürmez.
                                               //SetName: name alanına yeni bir değer atamak için kullanılır.
                                               //string newName: Kullanıcının atamak istediği yeni isim. Bu, metot çağrıldığında bir parametre olarak verilir.
        {
            name = newName;    //name = newName;: name alanına newName'in değeri atanır.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Account sınıfından bir nesne oluşturuyoruz
            Account myAccount = new Account();

            // İlk adı yazdırıyoruz (başlangıçta null olacaktır)
            Console.WriteLine($"Initial name is: {myAccount.GetName()}");

            // Kullanıcıdan bir isim girmesini istiyoruz
            Console.WriteLine("Enter the name: ");
            string thename = Console.ReadLine();

            // Kullanıcıdan alınan ismi nesneye atıyoruz
            myAccount.SetName(thename);

            // Yeni ismi yazdırıyoruz
            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
        }
    }
}

