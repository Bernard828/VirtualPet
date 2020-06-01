using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class OrganicPet : Pet
    {
        public  string NewName { get; set; }
        public bool NewPetType { get; set; }
        public string NewSpecies { get; set; }
        public int NewHunger { get; set; }
        public int NewThirst { get; set; }
        public int NewBoredom { get; set; }
        public int NewHealth { get; set; }

        public OrganicPet()
        {
            Hunger = 50;
            Thirst = 50;
            Boredom = 50;
            Health = 50;
        }

        public OrganicPet (string organicname)
        {
            base.Name = organicname;
        }

        public void NewSetName(string organicName)
        {
            NewName = organicName;
        }
        public void NewSetSpecies(string organicSpecies)
        {
            Species = organicSpecies;
        }
        public override string GetName()
        {
            return base.Name;
        }
        public override string GetSpecies()
        {
            return Species;
        }
    }
}
