using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }

        //Equals method is intended to return true when another object is supplied which is semantically equal to current instance.
        //GetHashCode method is intended to return an integer value which can be used as a hash code,
        //i.e. key that accompanies the object when object is stored in a hashed data structure
        public override bool Equals(object obj)  //originally Determines whether the specified object instances are considered equal.
        {
            Contact contact = (Contact)obj;
            if (contact == null)
                return false;
            else
                return FirstName.Equals(contact.FirstName) && LastName.Equals(contact.LastName);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }


        //we are overriding the original functionality of ToString method to return a custom requirement
        public override string ToString()  //Originally returns A string that represents the current object.
        {
            return "First Name :" + FirstName + "\nLast Name : " + LastName + "\nCity : " + City + "\nState : " + State + "\nEmail : " + Email + "\nZip : " + Zip + "\nPhone Number : " + PhoneNumber + "\n";
        }
    }
}
