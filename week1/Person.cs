using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1;

public class Person
{
    public Person(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
}
