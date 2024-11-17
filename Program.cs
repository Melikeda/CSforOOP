using System;

namespace Studentcs
{

    class Account
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

    class Program
    {
        static void Main() 
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is: {myAccount.Name}");

            Console.WriteLine("Enter the name: ");
            string thename = Console.ReadLine();

        
            myAccount.Name = thename;

           
            Console.WriteLine($"myAccount's name is: {myAccount.Name}");

        }
    }

}
