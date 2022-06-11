using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddNewContact
    {
        public void AddNewContact()
        {
            Contact newContact = CreateContact();
            addressBook.Add(newContact);
            if (totalEntries < entries.Length)
            {
                entries[totalEntries++] = newContact;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Added successfuly!");
                Console.ResetColor();

                Console.WriteLine("*****-> Details Of Person  <-*****");
                Console.WriteLine($"First Name: {newContact.FirstName}");
                Console.WriteLine($"Last Name: {newContact.LastName}");
                Console.WriteLine($"Address: {newContact.Address}");
                Console.WriteLine($"City Name: {newContact.City}");
                Console.WriteLine($"State Name: {newContact.State}");
                Console.WriteLine($"Postalcode: {newContact.PostalCode}");
                Console.WriteLine($"Phone Number: {newContact.PhoneNumber}");
                Console.WriteLine($"Email: {newContact.Email}");
                Console.WriteLine("==============================================================================");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Address Book is already full.");
                Console.ResetColor();
            }
        }
    }
}



