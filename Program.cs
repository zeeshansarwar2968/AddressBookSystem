using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\t\t\t\t\tWelcome To Address Book System!");
            Console.WriteLine("\t\t\t----------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("\t\t\t\t\tPress o to exit the program");
            Console.WriteLine("\t\t\t----------------------------------------------------------");
            Console.WriteLine();
            bool flag = false;

            while (!flag)
            {
                Console.Write("Please Enter an option for Execution or Press 0 to Exit: ");
                AddressBook addressBook = new AddressBook();
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 0:
                        flag = true;
                        break;
                    case 1:
                        addressBook.GetPersonalInfo();
                        addressBook.ListingContacts();
                        break;
                    case 2:
                        addressBook.GetPersonalInfo();
                        addressBook.Modify();
                        addressBook.ListingContacts();
                        break;
                    case 3:
                        addressBook.GetPersonalInfo();
                        addressBook.ListingContacts();
                        break;
                    case 4:
                        addressBook.GetPersonalInfo();
                        addressBook.RemovePeople();
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;

                }

            }
            



        }

        
    }
}