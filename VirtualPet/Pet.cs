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

        public int Sleep { get; set; }

        public int Health { get; set; }
        
        public Pet()
        {
            Health = 30;
            Hunger = 50;
            Thirst = 80;
            Sleep = 80;
        }
       public Pet(string name, string species)
       {
            Name = name;
            Species = species;
       }
        public void GetPetStats()
        {
            Console.WriteLine("\nEnter your pet's names:\t");
            Name = Console.ReadLine();

            Console.WriteLine("\nwhat is your pet's species: \t");
            Species = Console.ReadLine();
        }

        public void SetName(string name)
        {
            Name = name;
        }
        
        public void SetSpecies(string species)
        {
            Species = species;
        }

        public void SetHunger(int hunger)
        {
            Hunger = hunger;
        }

        public void SetThirst(int thirst)
        {
            Thirst = thirst;
        }

        public void SetSleep(int sleep)
        {
            Sleep = sleep;
        }

        public void SetHealth(int health)
        {
            Health = health;
        }

        public string GetName()
        {
            return Name;
        }
        public string GetSpecies( string species)
        {
            return species;
        }
                
        public int GetThirst()
        {
            return Thirst;
        }
        public int GetHunger()
        {
            return Hunger;
        }

        public int GetSleep()
        {
            return Sleep;
        }

        public int GetHealth()
        {
            return Health;
        }
  
        public void Feed()
        {
            Hunger = 50;
            Hunger += 5;
        }

        public void GiveWater()
        {
            Thirst += 5;
        }
        
        public void TakeNap()
        {
            Sleep += 30;
        }

        public void Play()
        {
            Hunger -= 10;
        }
        public void SeeDoctor()
        {
            Health += 30;
        }

        public void Tick()
        {
            Hunger += 5;
            Thirst += 5;
            Health -= 5;
            Sleep -= 5;
        }
    }
}
