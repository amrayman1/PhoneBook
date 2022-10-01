using System;

namespace PhonebookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneBook();
            Console.WriteLine("------------- Hello, This is Phonebook App -------------");
            Console.WriteLine("Select Operation: ");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. Search for Contact by Number");
            Console.WriteLine("3. Search for Contact by Name");
            Console.WriteLine("4. View All Contacts");
            Console.WriteLine("Press 'x' To Exit");
            var userInput = Console.ReadLine();

            do
            {
                
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number: ");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Enter Contact Number: ");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        Console.WriteLine("Enter Contact Name: ");
                        var searchName = Console.ReadLine();
                        phoneBook.DisplayMatchingContact(searchName);
                        break;
                    case "4":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "x":
                        return;
                    default:
                        break;
                }

                Console.WriteLine("Select Operation: ");
                userInput = Console.ReadLine();

            } while (true);
        }
    }
}
