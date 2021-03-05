using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsLiving = true;
            Legs = 2;
            HasTail = true;
            CanSing = true;
        }

        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public bool CanSing { get; set; }
        public string Name { get; set; }
        public bool EatsCrackers { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can Fly:{CanFly}");
            Console.WriteLine($"Can Sing:{CanSing}");
            Console.WriteLine($"Name:{Name}");
        }

        public Bird(int legs, bool hasTail, bool isLiving, bool canSwim, bool canFly, bool hasFeathers, bool canSing, bool eatsCrackers, string name)
        {
            Legs = legs;
            HasTail = hasTail;
            IsLiving = isLiving;
            CanSwim = canSwim;
            CanFly = canFly;
            HasFeathers = hasFeathers;
            CanSing = canSing;
            EatsCrackers = eatsCrackers;
            Name = name;
        }
    }
}
