using System;
using System.Net.Cache;

namespace ConsoleApp
{
    class Person
    {
        private int age;

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int newAge)
        {
            age = newAge;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person();

            myPerson.SetAge(23);

            Console.WriteLine($"myPerson's age is: {myPerson.GetAge()}");

        }
    }
}
