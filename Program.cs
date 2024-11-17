using System;

namespace Studentcs
{

    class Account
    {
        public string Name { get; set; }  // auto-implemented property

        public Account(string accountName)
        {
            Name = accountName;
        }

        
    }

    class Program
    {
        static void Main() 
        {
            Account myAccount = new Account("Melike Külahcı");

            Console.WriteLine($"myAccount's name is: {myAccount.Name}");

        }
    }

}
