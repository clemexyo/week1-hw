using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1;

public class PhoneNumber
{
    public PhoneNumber(string number, Person person)
    {
        Number = number;
        Person = person;
    }

    public string Number { get; set; }
    public Person Person { get; set; }
}
