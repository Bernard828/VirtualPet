using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {

        //private string name;
        //private string species;
        //private int hunger;
        //private int thirst;
        //private int boredom;
        //private int health;


        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }



        public Pet()
        {

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
        public int PetStats()
        {
            Hunger = 50;
            Thirst = 50;
            Boredom = 50;
            Health = 50;
        }
        public void GiveWater()
        {
            Thirst += 5;
        }
        public void Feed()
        { this.Hunger -= 5; }

        public void SeeDoctor()
        { this.Health += 30; }

        public void Play()
        {
            this.Hunger += 10; // hunger = hunger + 10
            this.Thirst += 20;
            this.Health += 10;
            this.Boredom -= 10;
        }
        public void Tick()
        {
            Hunger += 5;
            Thirst += 5;
            Health -= 5;
        }

        public void PrintEachPetsStats()
        {
            
            Console.WriteLine($"Pet: {Name}");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Thirst: {Thirst}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Boredom: {Boredom}");
        }
        //petTest.cs
        //public void RemoveDeadPEt()
        //{
        //  List<PEt> deadPEtList = new List <Pet>();
        //    foreach(Pet pet in PetShelterList)
        //    {
        //    bool IsDead =  pet.CheckPetDead()
        //    if (ISDead)
        //    {
       //         deadPetList.Add(pet)
                  //  cwl $"{pet.GetName} is dead!
        //        RemovePEtFromList(pet);
        //    }
        //    }
        //}
        ////pet.cs
        //public bool CheckIfDeadPet()
        //{
        //    if (Hunger >= 100)
        //    {
        //        return  true;
        //    }
        //    return false;
            
       // }
    }
}

   
