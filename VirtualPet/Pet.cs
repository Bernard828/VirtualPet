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
        public int Sickness { get; set; }

       public Pet (string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void SetName( string name)
        {
            Name = name;
        }
        public void GetName(string name)
        {
            Name = name;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }

    }
}
