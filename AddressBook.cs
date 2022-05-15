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
            Console.Write("-------To Modify-------\nEnter first name of user that needs modification : ");
            string name = Console.ReadLine();

            //Traverse till the desired index is reached for the contact info
            while (ContactArray[i].firstName != name)
            {
                i++;
            }

            Console.WriteLine("Enter field to be modified \n1.firstName \n2.lastName \n3.Address \n4.city \n5.state \n6.zip \n7.phoneNumber \n8.email");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.Write("Enter the modified value : ");
                    string fn = Console.ReadLine();
                    ContactArray[i].firstName = fn;
                    break;
                case 2:
                    Console.Write("Enter the modified value : ");
                    string ls = Console.ReadLine();
                    ContactArray[i].lastName = ls;
                    break;
                case 3:
                    Console.Write("Enter the modified value : ");
                    string add = Console.ReadLine();
                    ContactArray[i].Address = add;
                    break;
                case 4:
                    Console.Write("Enter the modified value : ");
                    string cities = Console.ReadLine();
                    ContactArray[i].city = cities;
                    break;
                case 5:
                    Console.Write("Enter the modified value : ");
                    string state1 = Console.ReadLine();
                    ContactArray[i].state = state1;
                    break;
                case 6:
                    Console.Write("Enter the modified value : ");
                    int tempZip = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].zip = tempZip;
                    break;
                case 7:
                    Console.Write("Enter the modified value : ");
                    int phoneN = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].phoneNumber = phoneN;
                    break;
                case 8:
                    Console.Write("Enter the modified value : ");
                    string email1 = Console.ReadLine();
                    ContactArray[i].email = email1;
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
