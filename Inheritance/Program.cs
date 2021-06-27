using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bulldogg", 20, 8, true, SmellStrength.Medium);
            Horse horse = new Horse("Horse", 350, 10, true, "Arabian");
            Hedgehog hedgehog = new Hedgehog("Hedgehog", 5, 2, true, 550);
            Worm worm = new Worm("Worm", 0.005, 3, false, false);
            Flamingo flamingo = new Flamingo("Flamingo", 4, 7, true, 100, true);
            Wolf wolf = new Wolf("Gray wolf", 55, 14, true, "Round");
            Wolfman wolfman = new Wolfman("Wolfman", 120, 66, true, "tall");

            List<Animal> Animals = new List<Animal>()
            { dog,horse,hedgehog,worm ,flamingo,wolf,wolfman};

            //////////////////////////////////////////////////
            Dog dog1 = new Dog("LABRADOR", 7, 3, true, SmellStrength.low);
            Dog dog2 = new Dog("GOLDEN ", 10, 5, true, SmellStrength.Medium);
            Dog dog3 = new Dog("GERMAN  ", 13, 4, true, SmellStrength.High);
            List<Dog> Dogs = new List<Dog>()
            { dog1,dog2 ,dog3};

            //9 .Q:I cannot add object from 'Horse' to 'Dog' (Different types)
            //10 .Q:The list must be from "Animal" type in order for all classes to be stored together

            //Dogs.Add(horse);//Error
            ///////////////////////////////////////////////////////////////
            
            Animals.AddRange(Dogs);

            foreach (var animal in Animals)
            {
                Console.WriteLine($"Animal type :{animal.GetType()}");
                if (animal is IPerson)
                {
                    IPerson Temp = (IPerson)animal;
                    Console.WriteLine($"Person sound :{Temp.Talk()}");
                }
                else if (animal is Dog)
                {
                    //16 .Q:I cannot access "Dog" new method from "Animal" class
                    //17.Q:because this method only in Dog class"base class cannot access methods in subclass" 
                    //18.Q:To print a new method for dog through a foreach on Animals ,cast "Animal" Type to "Dog" Type.

                    Dog Temp = (Dog)animal;
                    Console.WriteLine($"Dog sound :{Temp.DoSound()}");
                    Console.WriteLine(Temp.Dog_Puppy());
                }
                else
                {
                    Console.WriteLine($"Animal sound :{animal.DoSound()}");
                }
                Console.WriteLine(animal.Stats());
                Console.WriteLine();
            }
        

        }
    }
}
