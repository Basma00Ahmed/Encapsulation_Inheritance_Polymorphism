using System;

namespace Encapsulation
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        //1 Q: Access to private attributes indirect through public properties
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Age");
                }
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid First Name");
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Last Name");
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {

                    height = value;
                }
                else
                {
                    throw new ArgumentException("Invalide Height");
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Invalide Weight");
                }
            }
        }
        public Person()
        {

        }
        public Person(string fname, string lname, int age, double height, double weight)
        {

            FName = fname;
            LName = lname;
            Age = age;
            Height = height;
            Weight = weight;

        }
        public override string ToString()
        {
            return $"First Name: {FName}  || Last Name: {LName}  || Age:{Age} || Height: {Height} CM|| Weight:{Weight} KG ";
        }
    }

       
}