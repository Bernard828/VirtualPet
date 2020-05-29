using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public List<Pet> allPets = new List<Pet>();

        public void AddPet(Pet pet)
        {
            allPets.Add(pet);
        }
        
        public void RemovePet(Pet pet)
        {
         allPets.Remove(pet);
        }
        
        public void PrintPetStats()
        {
            Console.WriteLine("\nList of pets in this shelter");

            foreach (Pet pet in allPets)
            {
                Console.WriteLine("\n");
              pet.PrintThisPetStats();
            }
        }

        public void FeedAll()
        {
            foreach( Pet pet in allPets)
            {
                pet.Feed();
                Console.WriteLine("\nYou fed all of your pet!");
            }            
        }

        public void WaterAll()
        {
            foreach (Pet pet in allPets)
            {
                pet.GiveWater();
                Console.WriteLine("\nYou gave all of your pets water!");
            }
        }

        public void SeeDoctorAll()
        {
            foreach (Pet pet in allPets)
            {
                pet.SeeDoctor();
            }
        }

        public void PlayWithAll()
        {
            foreach (Pet pet in allPets)
            {
                pet.Play();
            }
        }
    }
}
