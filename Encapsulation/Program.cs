using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //  Person person = new Person("Basma", "Ahmed", 36, 1.62, 80);
                Person person = new Person();
                person= person.CreatePerson("Basem", "Ahmed", 55, 1.62, 80);
                Console.WriteLine(person.ToString());
                person = person.CreatePerson("Alex", "Jone", 30, 1.8, 90);
                Console.WriteLine(person.ToString());
                person.SetFirstName (person,"Maya");
                person.SetLastName(person, "Karlos");
                person.SetAge(person, 22);
                person.SetHeight(person, 1.55);
                person.SetWeight(person, 60.5);
                Console.WriteLine(person.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
