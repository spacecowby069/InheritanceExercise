using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsLiving = true;
            Legs = 4;
            HasTail = true;
            CanSwim = true;
        }

        public bool IsColdBlooded { get; set; }
        public string Moves { get; set; }
        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Is Cold Blooded:{IsColdBlooded}");
            Console.WriteLine($"How moves:{Moves}");
        }
    }
}
