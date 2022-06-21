﻿using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Program header
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\t  ----------------------------------------------");
            Console.WriteLine("\t\t\t\t  Welcome to Address Book Program");
            Console.WriteLine("\t\t\t  ----------------------------------------------");
            Console.ResetColor();

            //Object of class AddressBook
            AddressBook addressBook = new AddressBook();
            int choice, choice2;
            string bookName = "MyBook";

            Console.WriteLine("What Would You Like to do -- \n 1.Work on default AddressBook \n 2.Create New AddressBook\n");
            Console.Write("\nPlease enter your choice : ");
            choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    addressBook.AddAddressBook(bookName);
                    break;
                case 2:
                    Console.WriteLine("Enter Name Of New Addressbook You want to create : ");
                    bookName = Console.ReadLine();
                    addressBook.AddAddressBook(bookName);
                    break;
            }

            do
            {
                Console.WriteLine($"Working On {bookName} AddressBook\n");
                Console.WriteLine("Choose An Option \n1.Add New Contact \n2.Edit Existing Contact \n3.Delete A Contact \n4.View A Contact \n5.View All Contacts \n6.Add New AddressBook \n7.Switch AddressBook \n8.Search Contact by city/state \n9.Count by State or City \n10.Sort");
                Console.ForegroundColor= ConsoleColor.Blue;
                Console.WriteLine("0.Exit Application\n");
                Console.ResetColor();
                Console.Write("Please enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\t\t\t\t----------------------------------------------");                        
                        Console.WriteLine("\t\t\t\t   Thank You For Using Address Book System.");
                        Console.WriteLine("\t\t\t\t----------------------------------------------");
                        Console.ResetColor();
                        break;

                    case 1:
                        Console.Write("Enter First Name :");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name :");
                        string lastName = Console.ReadLine();
                        Contact temp = new Contact(firstName, lastName, null, null, null, null, 0, 0);
                        if (addressBook.CheckDuplicateEntry(temp, bookName))
                        {
                            break;
                        }
                        Console.Write("Enter Address :");
                        string address = Console.ReadLine();
                        Console.Write("Enter City :");
                        string city = Console.ReadLine();
                        Console.Write("Enter State :");
                        string state = Console.ReadLine();
                        Console.Write("Enter Email :");
                        string email = Console.ReadLine();
                        Console.Write("Enter Zip :");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Phone Number :");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        addressBook.AddContact(firstName, lastName, address, city, state, email, zip, phoneNumber, bookName);
                        break;

                    case 2:
                        Console.WriteLine("Enter First Name Of Contact To Edit :");
                        string nameToEdit = Console.ReadLine();
                        addressBook.EditContact(nameToEdit, bookName);
                        break;

                    case 3:
                        Console.WriteLine("Enter First Name Of Contact To Delete :");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete, bookName);
                        break;

                    case 4:
                        Console.WriteLine("Enter First Name Of Contact To View :");
                        string nameToView = Console.ReadLine();
                        addressBook.ViewContact(nameToView, bookName);
                        break;

                    case 5:
                        addressBook.ViewContact(bookName);
                        break;

                    case 6:
                        Console.WriteLine("Enter Name For New AddressBook");
                        string newAddressBook = Console.ReadLine();
                        addressBook.AddAddressBook(newAddressBook);
                        Console.WriteLine("Would you like to Switch to " + newAddressBook);
                        Console.WriteLine("1.Yes \n2.No");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (c == 1)
                        {
                            bookName = newAddressBook;
                        }
                        break;

                    case 7:
                        Console.WriteLine("Enter Name Of AddressBook From Below List");
                        foreach (KeyValuePair<string, AddressBook> item in addressBook.GetAddressBook())
                        {
                            Console.WriteLine(item.Key);
                        }
                        while (true)
                        {
                            bookName = Console.ReadLine();
                            if (addressBook.GetAddressBook().ContainsKey(bookName))
                            {
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No such AddressBook found. Try Again.");
                                Console.ResetColor();
                            }
                        }
                        break;

                    case 8:
                        Console.WriteLine("Would You Like To \n1.Search by city \n2.Search by state");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                Console.Write("Enter name of city : ");
                                addressBook.SearchPersonByCity(Console.ReadLine());
                                break;
                            case 2:
                                Console.Write("Enter name of state : ");
                                addressBook.SearchPersonByState(Console.ReadLine());
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input. Enter Either 1 or 2");
                                Console.ResetColor();
                                break;
                        }
                        break;

                    case 9:
                        addressBook.DisplayCountByCityandState();
                        break;

                    case 10:
                        Console.WriteLine("\n1.Sort By Name \n2.Sort By City \n3.Sort By State \n4.Sort By Zip");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                addressBook.SortByName();
                                break;
                            case 2:
                                addressBook.SortByCity();
                                break;
                            case 3:
                                addressBook.SortByState();
                                break;
                            case 4:
                                addressBook.SortByZip();
                                break;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Entry. Enter value between 0 to 8");
                        Console.ResetColor();
                        break;
                }
            } while (choice != 0);
        }
    }
}