using System;

namespace HelloWorldCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool hasUsername = !string.IsNullOrWhiteSpace(username);
            bool hasPassword = !string.IsNullOrWhiteSpace(password) && password.Length >= 8;

            if (hasUsername && hasPassword)
            {
                Console.Write("Valid input");
            }
            else
            {
                Console.Write("Invalid input");
            }

            Console.Read();
        }
    }
}
