using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class Robotic :Pet
    {
        public void CreatePet()
        {
            Console.WriteLine("\n\tWhat's the animal's name?");

            string name = Console.ReadLine();

            SetName(name);

            Console.WriteLine("\n\tWhat type of animal? Don't forget to include 'Robotic' before species.");

            string species = Console.ReadLine();

            SetSpecies(species);
        }
    }
}
