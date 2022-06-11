namespace AddressBookSystem
{
    class program
    {
        public static void Main(string[] args)
        {
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 0:
                    AddNewContact addNewContact = new AddNewContact();
                    addNewContact.AddNewContact();
                    break;
                case 1:
                    CreateContact createContact = new CreateContact();
                    createContact.Contacts();
                    break;
                case 2:
                    DeleteContact deleteContact = new DeleteContact();
                    deleteContact.EditContact(string firstname, string lastname);
                    break;
                case 3:
                    Edit edit = new Edit();
                    edit.EditContact();
                    break;


            }
        }
    }
}