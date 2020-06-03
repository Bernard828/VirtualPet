using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public bool OrganicPet { get; set; }
        public bool Robotic { get; set; }

        public List<Pet> allPetsList = new List<Pet>();
        

        public PetShelter()
        {
        }

        public void AddPet(Pet pet)
        {
            allPetsList.Add(pet);
        }
               
        public void PrintAllPetsList()
        {
            int listnumber = 1;
            Console.WriteLine("\tList of Pets!!!");
            foreach (Pet pet in allPetsList)
            {
                string Name = pet.GetName();
                Console.WriteLine($"\t{listnumber}.{Name}");
                listnumber++;
            }
        }

        public Pet FindAnimalByIndex()
        {
            int numberForPet = Convert.ToInt32(Console.ReadLine());
            int selectedPet = (numberForPet - 1);
            Console.WriteLine(selectedPet);
            return allPetsList[selectedPet];
        }
        public void AdoptPet(Pet pet)
        {
            allPetsList.Remove(pet);
        }
        
        public void FeedAll()
        {
            foreach( Pet pet in allPetsList)
            {
                pet.Feed();
            }            
        }

        public void WaterAll()
        {
            foreach (Pet pet in allPetsList)
            {
                pet.GiveWater();
            }
        }

        public void SeeDoctorAll()
        {
            foreach (Pet pet in allPetsList)
            {
                pet.SeeDoctor();
            }
        }

        public void PlayWithAll()
        {
            foreach (Pet pet in allPetsList)
            {
                pet.Play();
            }
        }
     
        public void TickOnAllPets()
        {
            foreach( Pet pet in allPetsList)
            {
                pet.Tick();
            }
        }
    }
}
