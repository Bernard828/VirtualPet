using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public Pet()
        {
            Hunger = 50;
            Thirst = 50;
            Boredom = 50;
            Health = 50;
        }
        public Pet(string name)
        {
            Name = name;
        }

        public void SetName(string petName)
        {
            Name = petName;
        }

        public void SetSpecies(string petSpecies)
        {
            Species = petSpecies;
        }
        public void SetHunger()
        {
            Hunger = 50;
        }
        
        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return Species;
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

        public int GetBoredom()
        {
            return Boredom;
        }
        public void GiveWater()
        {
            Thirst += 5;
            Console.WriteLine($"You gave {Name} some water. Thirst: {Thirst}");
        }
        public void Feed()
        {
            this.Hunger += 5;
            Console.WriteLine($"You fed {Name} now. Hunger: {Hunger}");
        }

        public void SeeDoctor()
        { 
            this.Health += 30;
            Console.WriteLine($"{Name} is feeling much better! Health: {Health}");
        }

        public void Play()
        {
            this.Hunger += 10; 
            this.Thirst += 20;
            this.Health += 10;
            this.Boredom -= 10;
            Console.WriteLine($"\n{Name}: 'That was fun!' " +
                $"Hunger:{Hunger}| Thirst:{Thirst}| Health:{Health}| Boredom:{Boredom}");
        }
        public void Tick()
        {
            Hunger += 5;
            Thirst += 5;
            Health -= 5;
        }

        public void PrintThisPetStats()
        {
            
            Console.WriteLine($"Pet: {Name}");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Thirst: {Thirst}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Boredom: {Boredom}");
        }
         public void CreatePet()
        {
            Console.WriteLine("\nWhat's the animal's name?");

            string name = Console.ReadLine();

            SetName(name);

            Console.WriteLine("\nWhat type of animal?");

            string species = Console.ReadLine();

           SetSpecies(species);
        }
    }
}

   
