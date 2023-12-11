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
    }
}
