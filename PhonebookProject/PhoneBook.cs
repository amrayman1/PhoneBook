using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookProject
{
    public class PhoneBook
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"ContactName = {contact.Name}, ContactNumber = {contact.Number}");
        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = contacts.FirstOrDefault(c => c.Number == number);
            if(contact.Name == null)
                Console.WriteLine("Contact Not Found");
            else
                DisplayContactDetails(contact);
        }

        public void DisplayAllContacts()
        {
            DisplayContactsDetails(contacts);
        }

        public void DisplayMatchingContact(string searchContact)
        {
            var matchingContact = contacts.Where(c => c.Name.Contains(searchContact)).ToList();
            DisplayContactsDetails(matchingContact);
        }

    }
}
