using System;

namespace OOP_Inheritance_Ornek
{
    // 1️⃣ ABSTRACT CLASS
    abstract class Hayvan
    {
        // 2️⃣ NORMAL METHOD
        public void NefesAl()
        {
            Console.WriteLine("Hayvan nefes alıyor");
        }

        // 3️⃣ VIRTUAL METHOD
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor");
        }

        // 4️⃣ ABSTRACT METHOD
        public abstract void HareketEt();

        // 5️⃣ STATIC METHOD
        public static void Bilgi()
        {
            Console.WriteLine("Hayvanlar canlıdır");
        }
    }

    // INHERITANCE
    class Kopek : Hayvan
    {
        // Virtual method override
        public override void SesCikar()
        {
            Console.WriteLine("Köpek havlıyor");
        }

        // Abstract method override (zorunlu)
        public override void HareketEt()
        {
            Console.WriteLine("Köpek koşuyor");
        }
    }

    // SEALED METHOD
    class Kangal : Kopek
    {
        // Bu method artık daha fazla override edilemez
        public sealed override void SesCikar()
        {
            Console.WriteLine("Kangal güçlü havlıyor");
        }
    }

    // Bu sınıf hata vermemesi için override YOK
    class YavruKangal : Kangal
    {
        public void Oyna()
        {
            Console.WriteLine("Yavru kangal oynuyor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek = new Kopek();
            kopek.NefesAl();     // Normal
            kopek.SesCikar();    // Virtual -> override
            kopek.HareketEt();   // Abstract

            Console.WriteLine("------------------");

            Kangal kangal = new Kangal();
            kangal.NefesAl();    // Normal (inherit)
            kangal.SesCikar();   // Sealed override
            kangal.HareketEt();  // Abstract override (Kopek'ten)

            Console.WriteLine("------------------");

            // Static method (nesne gerekmez)
            Hayvan.Bilgi();

            Console.ReadLine();
        }
    }
}
