using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook : IContacts  //Using and inheriting from the Icnotacts interface created 
    {
        //First dictionary to store a simple contactbook
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        //second dictionary to store multiple contactbooks
        private Dictionary<string, AddressBook> addressBookDictionary = new Dictionary<string, AddressBook>();

        //Dictionaries to store filtered city and state information
        private Dictionary<Contact, string> cityDictionary = new Dictionary<Contact, string>();
        private Dictionary<Contact, string> stateDictionary = new Dictionary<Contact, string>();

        //Method to add contact info for each person
        public void AddContact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber, string bookName)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, email, zip, phoneNumber);
            addressBookDictionary[bookName].addressBook.Add(contact.FirstName, contact);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAdded Succesfully. \n");
            Console.ResetColor();
           
        }

        //Method to display contact info for a person
        public void ViewContact(string name, string bookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[bookName].addressBook)
            {
                if (item.Key.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("First Name : " + item.Value.FirstName);
                    Console.WriteLine("Last Name : " + item.Value.LastName);
                    Console.WriteLine("Address : " + item.Value.Address);
                    Console.WriteLine("City : " + item.Value.City);
                    Console.WriteLine("State : " + item.Value.State);
                    Console.WriteLine("Email : " + item.Value.Email);
                    Console.WriteLine("Zip : " + item.Value.Zip);
                    Console.WriteLine("Phone Number : " + item.Value.PhoneNumber + "\n");
                }
            }
        }

        //Method to display contacts from a contactbook/addressbook
        public void ViewContact(string bookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[bookName].addressBook)
            {
                Console.WriteLine("First Name : " + item.Value.FirstName);
                Console.WriteLine("Last Name : " + item.Value.LastName);
                Console.WriteLine("Address : " + item.Value.Address);
                Console.WriteLine("City : " + item.Value.City);
                Console.WriteLine("State : " + item.Value.State);
                Console.WriteLine("Email : " + item.Value.Email);
                Console.WriteLine("Zip : " + item.Value.Zip);
                Console.WriteLine("Phone Number : " + item.Value.PhoneNumber + "\n");
            }
        }

        //Method to edit the present addressbook/contact
        public void EditContact(string name, string bookName)
        {
            foreach (KeyValuePair<string, Contact> item in addressBookDictionary[bookName].addressBook)
            {
                if (item.Key.Equals(name))
                {
                    Console.WriteLine("Choose the field to edit \n1.First Name \n2.Last Name \n3.Address \n4.City \n5.State \n6.Email \n7.Zip \n8.Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter New First Name :");
                            item.Value.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter New Last Name :");
                            item.Value.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Enter New Address :");
                            item.Value.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Enter New City :");
                            item.Value.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Enter New State :");
                            item.Value.State = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("Enter New Email :");
                            item.Value.Email = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("Enter New Zip :");
                            item.Value.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.Write("Enter New Phone Number :");
                            item.Value.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nEdited Successfully.\n");
                    Console.ResetColor();
                }
            }
        }

        //Logic to delete contacts from the book
        public void DeleteContact(string name, string bookName)
        {
            if (addressBookDictionary[bookName].addressBook.ContainsKey(name))
            {
                addressBookDictionary[bookName].addressBook.Remove(name);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDeleted Succesfully.\n");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNot Found, Try Again.\n");
                Console.ResetColor();

            }
        }

        //Add a book to the address dictionary/database
        public void AddAddressBook(string bookName)
        {
            AddressBook addressBook = new AddressBook();
            addressBookDictionary.Add(bookName, addressBook);
            Console.WriteLine("AddressBook Created.");
        }
        public Dictionary<string, AddressBook> GetAddressBook()
        {
            return addressBookDictionary;
        }


        //logic to attain values 
        public List<Contact> GetListOfDictionaryValues(string bookName)
        {
            List<Contact> book = new List<Contact>();
            foreach (var value in addressBookDictionary[bookName].addressBook.Values)
            {
                book.Add(value);
            }
            return book;
        }

        //logic to attain keys
        public List<Contact> GetListOfDictionaryKeys(Dictionary<Contact, string> d)
        {
            List<Contact> book = new List<Contact>();
            foreach (var value in d.Keys)
            {
                book.Add(value);
            }
            return book;
        }

        //Logic for duplicate entry check
        public bool CheckDuplicateEntry(Contact c, string bookName)
        {
            List<Contact> book = GetListOfDictionaryValues(bookName);
            if (book.Any(b => b.Equals(c)))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Name already Exists.");
                Console.ResetColor();  
                return true;
            }
            return false;
        }


        //public List<Contact> GetListOfDictionaryValues1(Dictionary<string, Contact> d)
        //{
        //    List<Contact> book = new List<Contact>();
        //    foreach (var value in d.Values)
        //    {
        //        book.Add(value);
        //    }
        //    return book;
        //}


        //Logic/method to search Person by city
        public void SearchPersonByCity(string city)
        {
            foreach (AddressBook addressbookobj in addressBookDictionary.Values)
            {
                CreateCityDictionary();
                List<Contact> contactList = GetListOfDictionaryKeys(addressbookobj.cityDictionary);
                foreach (Contact contact in contactList.FindAll(c => c.City.Equals(city)).ToList())
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }

        //Logic/method to search Person by state
        public void SearchPersonByState(string state)
        {
            foreach (AddressBook addressbookobj in addressBookDictionary.Values)
            {
                CreateStateDictionary();
                List<Contact> contactList = GetListOfDictionaryKeys(addressbookobj.stateDictionary);
                foreach (Contact contact in contactList.FindAll(c => c.State.Equals(state)).ToList())
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }

        //method to create the required city dictionary
        public void CreateCityDictionary()
        {
            foreach (AddressBook addressBookObj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookObj.addressBook.Values)
                {
                    addressBookObj.cityDictionary.Add(contact, contact.City);
                }
            }
        }

        //method to create the required state dictionary
        public void CreateStateDictionary()
        {
            foreach (AddressBook addressBookObj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookObj.addressBook.Values)
                {
                    addressBookObj.stateDictionary.Add(contact, contact.State);
                }
            }
        }


        //Method to Display contact count on the basis of city or state 
        public void DisplayCountByCityandState()
        {
            CreateCityDictionary();
            CreateStateDictionary();
            Dictionary<string, int> countByCity = new Dictionary<string, int>();
            Dictionary<string, int> countByState = new Dictionary<string, int>();
            foreach (var obj in addressBookDictionary.Values)
            {
                foreach (var person in obj.cityDictionary)
                {
                    countByCity.TryAdd(person.Value, 0);  //If the key already exists, TryAdd does nothing and returns false
                    countByCity[person.Value]++;
                }
            }
            Console.WriteLine("City wise count :");
            foreach (var person in countByCity)
            {
                Console.WriteLine(person.Key + ":" + person.Value);
            }
            foreach (var obj in addressBookDictionary.Values)
            {
                foreach (var person in obj.stateDictionary)
                {
                    countByState.TryAdd(person.Value, 0);
                    countByState[person.Value]++;
                }
            }
            Console.WriteLine("State wise count :");
            foreach (var person in countByState)
            {
                Console.WriteLine(person.Key + ":" + person.Value);
            }
        }

        public void SortByName()
        {
            foreach (AddressBook addressBookobj in addressBookDictionary.Values)
            {
                List<string> list = addressBookobj.addressBook.Keys.ToList();
                list.Sort();
                foreach (string name in list)
                {
                    Console.WriteLine(addressBookobj.addressBook[name].ToString());
                }
            }
        }

    }

}
    
    
