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

            //Create object addressBookSystem for Class AddressBook
            AddressBook addressBookSystem = new AddressBook();
            Console.Write("\nPlease Enter number of Contacts to Add : ");
            int contacts = Convert.ToInt32(Console.ReadLine());

            //Input contact values from user
            while (contacts > 0)
            {
                Console.Write("\nEnter Firstname : ");
                string firstname = Console.ReadLine();
                Console.Write("\nEnter Lastname : ");
                string lastname = Console.ReadLine();

                Console.Write("\nEnter Address : ");
                string address = Console.ReadLine();

                Console.Write("\nEnter City : ");
                string city = Console.ReadLine();

                Console.Write("\nEnter State : ");
                string state = Console.ReadLine();

                Console.Write("\nEnter pincode : ");
                int pincode = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter PhoneNumber : ");
                long phone = Convert.ToInt64(Console.ReadLine());

                Console.Write("\nEnter Email : ");
                string email = Console.ReadLine();

                //Call Method
                addressBookSystem.CreateContact(firstname, lastname, address, city, state, pincode, phone, email);
                contacts--;
            }

            //Check if any modification is needed in the built addressbook
            Console.WriteLine("Do you want to Modify?(Y/N)");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch =='y')
            {
                addressBookSystem.Modify();
            }

        }

        //method to display the contactbook
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