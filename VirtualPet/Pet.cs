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
        public bool PetType { get; set; }
        public string Species { get; set; }
       public int Boredom { get; set; }

        public Pet()
        {
           
            Boredom = 50;
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

        public virtual string GetName()
        {
            return Name;
        }

        public virtual string GetSpecies()
        {
            return Species;
        }
        public int GetBoredom()
        {
            return Boredom;
        }
        public virtual void CreatePet()
        {

        }

        public virtual void GiveWater()
        {
           
        }
        public virtual void Feed()
        {

        }

        public virtual void SeeDoctor()
        {
         
        }


        public virtual void Play()
        { 

        }
        public virtual void Tick()
        {
        }

        public virtual void PrintThisPetStats()
        {

        }
    }
}

   
