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
                PersonHandler personhandler = new PersonHandler();
                Person person = new Person();
                person = personhandler.CreatePerson("Basem", "Ahmed", 55, 1.62, 80);
                Console.WriteLine(person.ToString());
                person = personhandler.CreatePerson("Alex", "Jone", 30, 1.8, 90);
                Console.WriteLine(person.ToString());
                personhandler.SetFirstName (person,"Maya");
                personhandler.SetLastName(person, "Karlos");
                personhandler.SetAge(person, 22);
                personhandler.SetHeight(person, 1.55);
                personhandler.SetWeight(person, 60.5);
                Console.WriteLine(person.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
