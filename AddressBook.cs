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
        public AddressBook[] ContactArray;
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

        //Default Contructor
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

    }

    
    

    
}
