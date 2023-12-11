using System.Xml.Linq;
using week1;

class Program
{
    static void Main()
    {
        Person person1 = new Person("name1", "lastname1");
        Person person2 = new Person("name2", "lastname2");
        Person person3 = new Person("name3", "lastname3");
        Person person4 = new Person("name4", "lastname4");
        Person person5 = new Person("name5", "lastname5");

        PhoneNumber phoneNumber1 = new PhoneNumber("1", person1);
        PhoneNumber phoneNumber2 = new PhoneNumber("2", person2);
        PhoneNumber phoneNumber3 = new PhoneNumber("3", person3);
        PhoneNumber phoneNumber4 = new PhoneNumber("4", person4);
        PhoneNumber phoneNumber5 = new PhoneNumber("5", person5);

        PhoneBook phoneBook = new PhoneBook();
        phoneBook.AddNumber(phoneNumber1);
        phoneBook.AddNumber(phoneNumber2);
        phoneBook.AddNumber(phoneNumber3);
        phoneBook.AddNumber(phoneNumber4);
        phoneBook.AddNumber(phoneNumber5);

        //the menu
        while (true)
        {
            Console.WriteLine("Please select one, type 'exit' to finish the process\n");
            Console.WriteLine("(1) Add new number\n" +
                              "(2) Delete number\n" +
                              "(3) Update number\n" +
                              "(4) Display phone book\n" +
                              "(5) Search in the phone book.\n");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Please enter name: ");
                string name = Console.ReadLine();

                Console.Write("Please enter last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Please enter phone number: ");
                string phoneNumber = Console.ReadLine();

                Person toBeAddedPerson = new Person(name, lastName);
                PhoneNumber toBeAddedNumber = new PhoneNumber(phoneNumber, toBeAddedPerson);

                phoneBook.AddNumber(toBeAddedNumber);
            }
            else if (option == "2")
            {
                Console.Write("Please enter the name of the person whom you want to delete the number of: ");
                while (true)
                {
                    string name = Console.ReadLine();
                    PhoneNumber toBeDeleted = phoneBook.FindByName(name);

                    if (toBeDeleted is null)
                    {
                        Console.WriteLine("Could not find that person in the phone book. Please choose an action");
                        Console.WriteLine("End deleting process : (1)");
                        Console.WriteLine("Try again : (2)");

                        string deletingOption = Console.ReadLine();
                        if (deletingOption == "1")
                        {
                            break;
                        }
                        else if (deletingOption == "2")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Ending the deleting process.\n");
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("You are about the delete {}, do you accept? (y/n): ");
                        string deletingOption = Console.ReadLine();
                        if (deletingOption == "y")
                        {
                            phoneBook.DeleteNumber(toBeDeleted);
                            break;
                        }
                        else if (deletingOption == "n")
                        {
                            Console.WriteLine("Redirecting...\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, redirecting...\n");
                            break;
                        }

                    }
                }

            }
            else if (option == "3")
            {
                Console.Write("Please enter the name of the person whom you want to update the number of: ");
                while (true)
                {
                    string name = Console.ReadLine();
                    PhoneNumber toBeUpdated = phoneBook.FindByName(name);

                    if (toBeUpdated is null)
                    {
                        Console.WriteLine("Could not find that person in the phone book. Please choose an action");
                        Console.WriteLine("End updating process : (1)");
                        Console.WriteLine("Try again : (2)");

                        string updatingOption = Console.ReadLine();
                        if (updatingOption == "1")
                        {
                            break;
                        }
                        else if (updatingOption == "2")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Ending the updating process.\n");
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("What should be the new number?: ");
                        string newNumber = Console.ReadLine();

                        phoneBook.UpdateNumber(toBeUpdated, newNumber);
                        break;
                    }
                }
            }
            else if(option == "4")
            {
                Console.Write("If you want to display A-Z type 'desc', if you want to display Z-A type 'asc'. Anything else if invalid input: ");
                string sorting = Console.ReadLine();
                phoneBook.SortBook(sorting);
            }
            else if(option == "5")
            {
                Console.WriteLine("Search with respect to name: (1)");
                Console.WriteLine("Search with respect to number: (2)");
                string searchOption = Console.ReadLine();

                if(searchOption == "1")
                {
                    Console.Write("Enter the name: ");
                    string name = Console.ReadLine();

                    PhoneNumber searchResult = phoneBook.FindByName(name);
                    if(searchResult is null)
                    {
                        Console.WriteLine("No such person. Redirecting....\n");
                    }
                    else
                    {
                        Console.WriteLine("Result of the search: ");
                        Console.WriteLine("Name: {1}, Last name: {2}, Phone number: {3}", searchResult.Person.Name, searchResult.Person.LastName, searchResult.Number);
                    }
                }
                if(searchOption == "2")
                {
                    Console.Write("Enter the number: ");
                    string number = Console.ReadLine();

                    PhoneNumber searchResult = phoneBook.FindByNumber(number);
                    if (searchResult is null)
                    {
                        Console.WriteLine("No such person. Redirecting....\n");
                    }
                    else
                    {
                        Console.WriteLine("Result of the search: ");
                        Console.WriteLine("Name: {1}, Last name: {2}, Phone number: {3}", searchResult.Person.Name, searchResult.Person.LastName, searchResult.Number);
                    }
                }
            }
            else if(option == "exit")
            {
                Console.WriteLine("Thanks for taking the time.\n");
                break;
            }
            else
            {
                Console.WriteLine("What are you trying to do? Redirecting....\n");
            }
        }
    }
}
