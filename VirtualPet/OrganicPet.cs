using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
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
            Console.WriteLine($"\t{Name}'s new thirst level ({Thirst})");
        }
        public override void Feed()
        {
            this.Hunger += 5;
            Console.WriteLine($"\t{Name}'s new hunger Level: {Hunger}");
        }

        public override void SeeDoctor()
        {

            this.Health += 30;
            Console.WriteLine($"\t{Name}'s new health level: ({Health})");
        }
        public override void Play()
        {
            this.Hunger += 10;
            this.Thirst += 20;
            this.Health += 10;
            this.Boredom -= 10;

            Console.WriteLine($"\n\t{Name}:" +
            $"\tHunger:{Hunger}, Thirst:{Thirst}, Health:{Health}, Boredom:{Boredom}");
            Console.WriteLine("That was fun!");
        }
        public override void Tick()
        {
            Hunger += 5;
            Thirst += 5;
            Health -= 5;
            Boredom += 5;

            Console.WriteLine($"\n\t{Name}:" +
            $"\tHunger:{Hunger}, Thirst:{Thirst}, Health:{Health}, Boredom:{Boredom}");
        }
        public override void PrintThisPetStats() 
        {
            int listnumber = 1;
            listnumber++;

            Console.WriteLine($"\t{listnumber}.  |\t {Name}\t||Health({Health})|Boredom ({Boredom})|Hunger({Hunger})|Thirst({Thirst})|{Species}");
        }
        public override void CreatePet()
        {
            Console.WriteLine("\n\tWhat's the animal's name?");

            string name = Console.ReadLine().ToUpper();

            SetName(name);


            Console.WriteLine("\n\tWhat type of animal?");

            string species = Console.ReadLine();

            SetSpecies(species);
        }
    }
}
