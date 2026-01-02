using System;

namespace ExtensionExample
{
    // 1. Static class olmalı
    public static class StringExtensions
    {
        // 2. Extension method olmalı (this ile)
        public static string ToUpperFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }

    class Program
    {
        static void Main()
        {
            string kelime = "merhaba";

            string sonuc = kelime.ToUpperFirst();

            Console.WriteLine(sonuc);
        }
    }
}
