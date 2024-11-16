using System;

namespace ConsoleApp
{
    class Book
    {
        // Özel alanlar (fields)
        private string title; // Kitap adı
        private string author; // Yazar adı

        // Getter metodu: 'title' alanının değerini döndürür
        public string GetTitle()
        {
            return title;
        }

        // Setter metodu: 'title' alanına bir değer atar
        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }

        // Getter metodu: 'author' alanının değerini döndürür
        public string GetAuthor()
        {
            return author;
        }

        // Setter metodu: 'author' alanına bir değer atar
        public void SetAuthor(string newAuthor)
        {
            author = newAuthor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Book sınıfından bir nesne oluşturuyoruz
            Book myBook = new Book();

            // Başlangıç değerlerini yazdırıyoruz (null olacaktır)
            Console.WriteLine($"Initial title is: {myBook.GetTitle()}");
            Console.WriteLine($"Initial author is: {myBook.GetAuthor()}");

            // Kullanıcıdan kitap adını alıyoruz
            Console.WriteLine("Enter the book title: ");
            string bookTitle = Console.ReadLine();
            myBook.SetTitle(bookTitle);

            // Kullanıcıdan yazar adını alıyoruz
            Console.WriteLine("Enter the author's name: ");
            string bookAuthor = Console.ReadLine();
            myBook.SetAuthor(bookAuthor);

            // Girilen değerleri yazdırıyoruz
            Console.WriteLine($"The book title is: {myBook.GetTitle()}");
            Console.WriteLine($"The author is: {myBook.GetAuthor()}");
        }
    }
}
