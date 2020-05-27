using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public Pet(string Name)
        {
            Name = "";
        }

        private string testPet;
        private string name;
        private string species;
        private int hunger;
        private int thirst;
        private int boredom;
        private int health;

        public string TestPet { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public void SetName(string petName)
        { Name = petName; }

        public void SetSpecies(string petSpecies)
        { Species = petSpecies; }

        public string GetName()
        { 
            return name;
        }

        public string GetSpecies()
        {
            return species;
        }

        public int GetHunger()
        {
            return hunger;
        }

        public int GetThirst()
        {
            return thirst;
        }

        public int GetHealth()
        {
            return health;
        }

        public void Feed()
        { Hunger -= 5; }

        public void SeeDoctor()
        { Health += 30; }

        public void Play()
        { 
            Hunger += 10;
            Thirst += 20;
            Health += 10;
        }

        public void Tick()
        {
            Hunger += 5;
            Thirst += 5;
            Health -= 5;
        }
    }
}

   
