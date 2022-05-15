using System;

namespace AddressBookSystem
{
    public class AddBooks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t Welcome to Address Book Program");
            Console.WriteLine("");


            //Console.WriteLine("Enter name of addressBook");
            //string addrBookName = Console.ReadLine();

            //Create object for Class
            AddressBook addressBookSystem = new AddressBook();
            Console.Write("Please Enter number of Contacts to Add : ");
            int contacts = Convert.ToInt32(Console.ReadLine());

            //Input contacts values from user
            while (contacts > 0)
            {
                Console.Write("Enter Firstname : ");
                string firstname = Console.ReadLine();
                Console.Write("Enter Lastname : ");
                string lastname = Console.ReadLine();

                Console.Write("Enter Address : ");
                string address = Console.ReadLine();

                Console.Write("Enter City : ");
                string city = Console.ReadLine();

                Console.Write("Enter State : ");
                string state = Console.ReadLine();

                Console.Write("Enter pincode : ");
                int pincode = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter PhoneNumber : ");
                long phone = Convert.ToInt64(Console.ReadLine());

                Console.Write("Enter Email : ");
                string email = Console.ReadLine();

                //Call Method
                addressBookSystem.CreateContact(firstname, lastname, address, city, state, pincode, phone, email);
                contacts--;
            }

            //Check if any modification needed
            Console.WriteLine("Do you want to Modify?(Y/N)");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y')
            {
                addressBookSystem.Modify();
            }

        }
        public void Display(AddressBook[] ContactArray, int N)
        {
            Console.WriteLine("---------Address Book Contains---------");
            int i;
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n", ContactArray[i].firstName, ContactArray[i].lastName, ContactArray[i].Address, ContactArray[i].city, ContactArray[i].zip, ContactArray[i].state, ContactArray[i].phoneNumber, ContactArray[i].email);

            }

        }
    }
}