using System;

namespace AccessModifiersExample
{
    // Base class (Temel sınıf)
    class Animal
    {
        private string secret = "Ben gizli bir bilgiyim";  // private: sadece Animal içinde erişilebilir
        protected string name = "Hayvan";                 // protected: Animal ve türetilmiş sınıflarda erişilebilir

        public void ShowInfo()
        {
            Console.WriteLine("Private secret: " + secret); // Base class içinde private kullanılabilir
            Console.WriteLine("Protected name: " + name);
        }
    }

    // Derived class (Türetilmiş sınıf)
    class Dog : Animal
    {
        public void ShowDogInfo()
        {
            // Console.WriteLine("Secret: " + secret); // HATA! private üye doğrudan erişilemez
            Console.WriteLine("Protected name (Dog sınıfından): " + name); // Erişilebilir
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.ShowInfo();

            Dog myDog = new Dog();
            myDog.ShowDogInfo();
        }
    }
}
