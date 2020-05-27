using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        private string testPet;
        private string name;
        private int hunger;
        private int thirst;
        private int boredome;
        private int sickness;
        public Pet(string name, string species)
        {
            this.name = name;
            this.species = species;
        }

        public string GetName()
        { 
            return name;
        }
    }
}

   
