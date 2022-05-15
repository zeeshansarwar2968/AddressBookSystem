using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        //instance variables 
        public string firstName;
        public string lastName;
        public string Address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;
        public AddressBook[] ContactArray;  //delclaration of an array to store class instances
        int contact = 0;


        //Parameterised Constructor to setup contacts
        public AddressBook(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }

        //Default Constructor for array declaration
        public AddressBook()
        {
            this.ContactArray = new AddressBook[10];
        }

        //To add Contact to Address Book
        public void CreateContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {

            ContactArray[this.contact] = new AddressBook(firstName, lastName, Address, city, state, zip, phoneNumber, email);
            contact++;
            AddBooks obj = new AddBooks();
            obj.Display(ContactArray, contact);
        }

        public void Modify()
        {
            //User enters field to Modify
            int i = 0;
            Console.WriteLine("-------To Modify-------\nEnter first name of user that needs modification");
            string name = Console.ReadLine();

            //Traverse till the desired index
            while (ContactArray[i].firstName != name)
            {
                i++;
            }

            Console.WriteLine("Enter field to be modified 1.firstName 2.lastName 3.Address 4.city 5.state 6.zip 7.phoneNumber 8.email 9.Delete a contact");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the modified value");
                    string fn = Console.ReadLine();
                    ContactArray[i].firstName = fn;
                    break;
                case 2:
                    Console.WriteLine("Enter the modified value");
                    string ls = Console.ReadLine();
                    ContactArray[i].lastName = ls;
                    break;
                case 3:
                    Console.WriteLine("Ente the modified value");
                    string add = Console.ReadLine();
                    ContactArray[i].Address = add;
                    break;
                case 4:
                    Console.WriteLine("Enter the modified value");
                    string cities = Console.ReadLine();
                    ContactArray[i].city = cities;
                    break;
                case 5:
                    Console.WriteLine("Enter the modified value");
                    string states = Console.ReadLine();
                    ContactArray[i].state = states;
                    break;
                case 6:
                    Console.WriteLine("Enter the modified value");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].zip = temp;
                    break;
                case 7:
                    Console.WriteLine("Ente the modified value");
                    int phn = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].phoneNumber = phn;
                    break;
                case 8:
                    Console.WriteLine("Ente the modified value");
                    string emails = Console.ReadLine();
                    ContactArray[i].email = emails;
                    break;
                //Delete a user
                case 9:
                    ContactArray = ContactArray.Take(i).Concat(ContactArray.Skip(i + 1)).ToArray();
                    contact--;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            //Display Function
            AddBooks obj = new AddBooks();
            obj.Display(ContactArray, contact);

        }

    }

}
