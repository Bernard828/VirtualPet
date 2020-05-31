using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class OrganicPet : Pet
    {
        public string Name { get; set; }
        public bool PetType { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        public OrganicPet()
        {
            Hunger = 50;
            Thirst = 50;
            Boredom = 50;
            Health = 50;
        }

        public OrganicPet (string name)
        {
            Name = name;
        }

        public void SetName(string organicName)
        {
            Name = Name;
        }
        public void SetSpecies(string organicSpecies)
        {
            organicSpecies = organicSpecies;
        }
        public override string GetName()
        {
            return Name;
        }
        public override string GetSpecies()
        {
            return Species;
        }
    }
}
