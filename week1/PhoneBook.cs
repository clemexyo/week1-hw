using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace week1;

public class PhoneBook
{
    private List<PhoneNumber> Numbers = new List<PhoneNumber>();

    public void AddNumber(PhoneNumber number) 
    {
        Numbers.Add(number);
        Console.WriteLine("Phone number added.\n");
    }
    public void DeleteNumber(PhoneNumber number) 
    {
        Numbers.Remove(number);
        Console.WriteLine("Phone number deleted.\n");
    }
    public void UpdateNumber(PhoneNumber number, PhoneNumber newPhoneNumber) 
    {
        int temp = Numbers.IndexOf(number);
        Numbers[temp] = newPhoneNumber;
        Console.WriteLine("Number updated.\n");
    }
    public void SortBook(string sorted) 
    {
        List<PhoneNumber> sortedList = Numbers.OrderBy(x => x.Person.Name).ToList();
        if (sorted == "desc")
        { 
            DisplayPhoneBook(sortedList);
        }
        else if(sorted == "asc")
        {
            sortedList.Reverse();
            DisplayPhoneBook(sortedList);
        }
        else
        {
            Console.WriteLine("What are you trying to do?\n");
        }
    }
    public PhoneNumber FindByName(string name) 
    {
        if (name is not null)
            return Numbers.FirstOrDefault(number => number.Person.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        else
            return null;
    }
    public PhoneNumber FindByNumber(PhoneNumber number) 
    {
        if (number is not null)
            return Numbers.FirstOrDefault(num => num == number);
        else
            return null;
    }
    static void DisplayPhoneBook(List<PhoneNumber> list)
    {
        foreach(PhoneNumber number in list)
        {
           Console.WriteLine($"Name: {number.Person.Name}, Last Name: {number.Person.LastName}, Phone: {number.Number}\n");
        }
    }
}
