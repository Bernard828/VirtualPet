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
        public void CreatePet()
        {
            Console.WriteLine("\n\tWhat's the animal's name?");

            string name = Console.ReadLine();

            SetName(name);

            Console.WriteLine("\n\tWhat type of animal?");

            string species = Console.ReadLine();

            SetSpecies(species);
        }

        public virtual void GiveWater()
        {
            Thirst += 5;
            Console.WriteLine($"\tYou gave {Name} some water. Thirst: {Thirst}");
        }
        public virtual void Feed()
        {
            this.Hunger += 5;
            Console.WriteLine($"\tYou fed {Name} now. Hunger: {Hunger}");
        }

        public virtual void SeeDoctor()
        {
            this.Health += 30;
            Console.WriteLine($"\t{Name} is feeling much better! Health: {Health}");
        }


        public void Play()
        {
            this.Hunger += 10;

            this.Thirst += 20;

            this.Health += 10;

            this.Boredom -= 10;

            Console.WriteLine($"\t{Name} enjoyed the exercise.");

            Console.WriteLine($"\n\t{Name}: 'That was fun!' " +
                $"\tHunger:{Hunger}| Thirst:{Thirst}| Health:{Health}| Boredom:{Boredom}");
        }
        public void Tick()
        {

            Hunger += 5;
            Thirst += 5;
            Health -= 5;
        }

        public void PrintThisPetStats()
        {

            Console.WriteLine($"\t Pet:{Name} | Boredom:{Boredom} | Hunger:{Hunger}| Thirst:{Thirst}| Health:{ Health  }");

        }
    }
}

   
