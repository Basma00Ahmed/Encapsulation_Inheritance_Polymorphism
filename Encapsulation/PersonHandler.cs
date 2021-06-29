using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public Person CreatePerson(string fname, string lname, int age, double height, double weight)
        {
            Person person = new Person(fname, lname, age, height, weight);
            return person;

        }
        public void SetFirstName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLastName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
