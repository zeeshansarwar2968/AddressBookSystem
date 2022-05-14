using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t Welcome to Address Book Program");
            Console.WriteLine("");
            AddressBook contact1 = new AddressBook("Zeeshan","Sarwar","Nyati Euphoria","Pune","Maharashtra",411011,9792432125,"z@gmail.com");
            AddressBook contact2 = new AddressBook("John", "Doe", "Empire State Building", "NY", "New York", 21010, 5443567, "jdoe@gmail.com");
            contact1.displayContact();
            contact2.displayContact();
            Console.ReadKey();
        }
    }
}