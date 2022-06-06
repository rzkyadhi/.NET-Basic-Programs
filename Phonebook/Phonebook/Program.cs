using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to phonebook Console APP !");
            Console.WriteLine("Choose one option on the below :");
            Console.WriteLine("1. Add a contact");

            int userChoice = Convert.ToInt32(Console.ReadLine());

            Phonebook phonebook = new();

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Input the name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Input the number");
                    string number = Console.ReadLine();
                    Contact newContact = new(name, number);
                    phonebook.AddContact(newContact);
                    break;
            }
        }
    }
}