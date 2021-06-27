using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

        public abstract class Animal
    {
        /// <summary>
        ///  ///14 Q: To add a new attribute for all animals we will add it here .
        /// private string TestAttribute;
        /// </summary>
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public bool HasBackbone { get; set; }
        public abstract string DoSound();
        public virtual string Stats()
        {
            string has_backbone = HasBackbone ? "Yes" : "No";
            return $"Name:{Name} || Weight: {Weight} KG || Age:{Age} || Has Backbone: {has_backbone} ";
        }
        public Animal(string name, double weight, int age, bool hasbackbone)
        {
            Name = name;
            Weight = weight;
            Age = age;
            HasBackbone = hasbackbone;
        }
    }

    //Animal Subclasses {Horse , Dog , Hedgehog , Worm och Bird, Wolf }.

    public class Horse : Animal
    {
        private string breed;
        public string Breed
        {
            get => breed;
            set => breed = string.IsNullOrEmpty(breed) ? "Unknown Breed" : value;
        }

        public override string DoSound() => "Neigh Neigh Neigh";
        public Horse(string name, double weight, int age, bool hasbackbone, string breed) : base(name, weight, age, hasbackbone)
        {
            Breed = breed;
        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            result.Append($" || Breed: {Breed} .");
            return result.ToString();
        }

    }
    public class Dog : Animal
    {

        public SmellStrength SmellStrength { get; set; }

        public override string DoSound() => "Wawgh Wawgh Wawgh";
        public Dog(string name, double weight, int age, bool hasbackbone, SmellStrength smellstrength) : base(name, weight, age, hasbackbone)
        {
            SmellStrength = smellstrength;
        }

        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            result.Append($" || Smell Strength: {SmellStrength} .");
            return result.ToString();
        }
        //New method in the Dog class
        public string Dog_Puppy() => "Puppy";
    }
    public class Hedgehog : Animal
    {
        private int nrofspikes;
        public int NrOfSpikes
        {
            get => nrofspikes;
            set => nrofspikes = Math.Max(0, value);
        }

        public override string DoSound() => "Squeaking Squeaking Squeaking";
        public Hedgehog(string name, double weight, int age, bool hasbackbone, int nrofspikes) : base(name, weight, age, hasbackbone)
        {
            NrOfSpikes = nrofspikes;
        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            result.Append($" || Number Of Spikes: {NrOfSpikes} .");
            return result.ToString();
        }
    }
    public class Worm : Animal
    {
        private bool ispoisonous;
        public bool IsPoisonous
        {
            get => ispoisonous;
            set => ispoisonous = value;
        }

        public override string DoSound() => "Worm Sound";
        public Worm(string name, double weight, int age, bool hasbackbone, bool ispoisonous) : base(name, weight, age, hasbackbone)
        {
            IsPoisonous = ispoisonous;
        }

        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            string Is_Poisonous = IsPoisonous ? "Yes" : "No";
            result.Append($" || Is Poisonous: {Is_Poisonous} .");
            return result.ToString();
        }
    }
    public class Bird : Animal
    {
        /// 13 Q: To add a new attribute for all birds we will add it here .
        /// private string TestAttribute;
        private double wingspan;
        public double WingSpan
        {
            get => wingspan;
            set => wingspan = Math.Max(0, value);
        }

        public override string DoSound() => "Tweet  Tweet Tweet";
        public Bird(string name, double weight, int age, bool hasbackbone, double wingspan) : base(name, weight, age, hasbackbone)
        {
            WingSpan = wingspan;
        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            result.Append($" || Wing Span: {WingSpan} CM.");
            return result.ToString();
        }
    }
    public class Wolf : Animal
    {
        private string earsshape;
        public string EarsShape
        {
            get => earsshape;
            set => earsshape = string.IsNullOrEmpty(earsshape) ? "Unknown Ears Shape" : value;
        }
        public override string DoSound() => "Owooooah Owooooah";
        public Wolf(string name, double weight, int age, bool hasbackbone, string earsshape) : base(name, weight, age, hasbackbone)
        {
            EarsShape = earsshape;
        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            result.Append($" || Ears Shape: {EarsShape} .");
            return result.ToString();
        }
    }

    // Birds Subclasses {Pelican , Flamingo and Swan}.
    public class Pelican : Bird
    {
        private double pouchsize;
        public double PouchSize
        {
            get => pouchsize;
            set => pouchsize = Math.Max(0, value);
        }
        public Pelican(string name, double weight, int age, bool hasbackbone, double wingspan, double pouchsize) : base(name, weight, age, hasbackbone, wingspan)
        {
            PouchSize = pouchsize;
        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            result.Append($" || Pouch Size: {PouchSize} .");
            return result.ToString();
        }
    }
    public class Flamingo : Bird
    {
        private bool standOnOneLeg;
        public bool StandOnOneLeg
        {
            get => standOnOneLeg;
            set => standOnOneLeg = value;
        }

        public Flamingo(string name, double weight, int age, bool hasbackbone, double wingspan, bool standOnOneLeg) : base(name, weight, age, hasbackbone, wingspan)
        {
            StandOnOneLeg = standOnOneLeg;

        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            string Stand_OnOneLeg = StandOnOneLeg ? "Yes" : "No";
            result.Append($" || Stand On One Leg: {Stand_OnOneLeg} .");
            return result.ToString();
        }
    }
    public class Swan : Bird
    {
        private bool canSwim;
        public bool CanSwim
        {
            get => canSwim;
            set => canSwim = value;
        }

        public Swan(string name, double weight, int age, bool hasbackbone, double wingspan, bool canSwim) : base(name, weight, age, hasbackbone, wingspan)
        {
            CanSwim = canSwim;

        }
        public override string Stats()
        {
            var result = new StringBuilder();
            result.Append(base.Stats());
            string Can_Swim = CanSwim ? "Yes" : "No";
            _ = result.Append($" || Can Swim: {Can_Swim} .");
            return result.ToString();
        }
    }

    //////////////////////////
    /// Wolf Subclasses {Wolfman}.
    public class Wolfman : Wolf, IPerson
    {
        public string Talk() => "Aroo Aroo Aroo";

        public Wolfman(string name, double weight, int age, bool hasbackbone, string earsshape) : base(name, weight, age, hasbackbone, earsshape)
        {

        }
    }

}
