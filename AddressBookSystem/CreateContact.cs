using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class CreateContact
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string State;
        public string City;
        public int Zip;
        public long PhoneNumber;
        public Contacts(string firstName, string lastName, string address, string state, string city, int zipcode, string contactNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.State = state;
            this.City = city;
            this.Zip = zip;
            long PhoneNumber = phoneNumber;
        }
        public string toString()
        {
            return "First Name:" + FirstName + "\nLast Name:" + LastName + "\nAddress:" + Address + "\nState:" + State + "\nCity:" + City + "\nZip:" + Zip + "\nPhoneNumber:" + PhoneNumber;
        }
    }
}
