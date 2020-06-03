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
        public override void Play()
        {
            this.Hunger += 10;

            this.Thirst += 20;

            this.Health += 10;

            this.Boredom -= 10;

            Console.WriteLine($"\t{Name} enjoyed the exercise.");

            Console.WriteLine($"\n\t{Name}: 'That was fun!' " +
                $"\tHunger:{Hunger}| Thirst:{Thirst}| Health:{Health}| Boredom:{Boredom}");
        }
        public override void Tick()
        {
            Hunger += 5;
            Thirst += 5;
            Health -= 5;
            Boredom += 5;
        }
        public override void PrintThisPetStats()
        {
            Console.WriteLine($"\t Pet:{Name} | Boredom:{Boredom} | Hunger:{Hunger}| Thirst:{Thirst}| Health:{ Health  }");
        }

    }
}
