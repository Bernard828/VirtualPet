using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class OrganicPet : Pet
    {
        public int Thirst { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }
      

        public OrganicPet() : base()
        {
            Hunger = 50;
            Thirst = 50;
            Health = 50;
        }
        public int GetHunger()
        {
            return Hunger;
        }
        public int GetThirst()
        {
            return Thirst;
        }
        public int GetHealth()
        {
            return Health;
        }

        public override void GiveWater()
        {
            Thirst += 5;
            Console.WriteLine($"\tYou gave {Name} some water. Thirst: {Thirst}");
        }
        public override void Feed()
        {
            this.Hunger += 5;
            Console.WriteLine($"\tYou fed {Name} now. Hunger: {Hunger}");
        }

        public override void SeeDoctor()
        {
            this.Health += 30;
            Console.WriteLine($"\t{Name} is feeling much better! Health: {Health}");
        }
    }
}
