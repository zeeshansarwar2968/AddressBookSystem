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
        //int contact = 0;


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

        public void displayContact()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Name : {0} {1}",firstName, lastName);
            Console.WriteLine("Address: "+Address);
            Console.WriteLine("City : "+ city);
            Console.WriteLine("State : " + state);
            Console.WriteLine("ZipCode : " + zip);
            Console.WriteLine("Phone Number : " + phoneNumber);
            Console.WriteLine("Email ID : " + email );
            Console.WriteLine("---------------------------------------------------------");

        }

    }

    
    

    
}
