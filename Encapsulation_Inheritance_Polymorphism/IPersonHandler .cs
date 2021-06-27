using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public interface IPersonHandler
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public void SetAge(Person pers,int age);
        public void SetFirstName(Person pers, string fName);
        public void SetLastName(Person pers, string lName);
        public void SetHeight(Person pers, double height);
        public void SetWeight(Person pers, double weight);
        public Person CreatePerson( string fname, string lname, int age,double height, double weight);
        string ToString();
    }
}
