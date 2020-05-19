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
        public string GetName{ get; set; }
        public string PetSpecies { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Sleepiness { get; set; }
        public int Sickness { get; set; }

       public Pet (string name, string setName, string species)
        {
            Name = setName;
            Petpecies = species;
        }
        //public void SetName (string setName)
        //{
        //    SetName = setName;
        //}
        //public void GetName (string name)
        //{
        //    Name = name;
        //}
        //public void Species(string species)
        //{;
        //    Species = species;
        //}
         
    }
}
