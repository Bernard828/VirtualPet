using System;
using System.Collections.Generic;
using System.Text;

namespace noahsArk
{
    public class Animal
    {
        public string Name { get; set; }
        private string Genus { get; set; }
        private string Species { get; set; }

        public Animal() { }

        public Animal(string name) { }

        public void SetName(string animalName)
        {
            Name = animalName;
        }

        public void SetGenus (string animalGenus)
        {
            Genus = animalGenus;
        }

        public void SetSpecies( string animalSpecies)
        {
            Species = animalSpecies;
        }

        public virtual string GetName()
        {
            return Name;
        }

        public virtual string GetGenus()
        {
            return Genus;
        }

        public virtual string GetSpecies()
        {
            return Species;
        }

        public virtual void CreateAnimal() { }
    }
}
