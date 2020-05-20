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
        public int Sleepiness { get; set; }
        public int Health { get; set; }
        
        public Pet()
        {
            Hunger = 50;
            Health = 30;
            Thirst = 50;
            Sleepiness = 80;

        }
       public Pet (string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void SetName( string name)
        {
            Name = name;
        }
        public string GetName(string name)
        {
            return name;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }
        public string GetSpecies( string species)
        {
            return species;
        }
        //public void SetHunger (int hunger)
        //{
        //    Hunger = hunger;
        //}

        public void Feed ()
        {
            Hunger -= 5;
        }

        public int GetHunger ()
        {
            return Hunger;
        }
        public int GetHealth ()
        {
            return Health;
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
        }
    }
}
