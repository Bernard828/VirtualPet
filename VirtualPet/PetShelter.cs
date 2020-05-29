using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
       
        public List<Pet> allPets = new List<Pet>();
        
       private object indexPetName;

        public void AddPet(Pet pet)
        {
            //int[] = allPets.Contains(pet);

            allPets.Add(pet);

            Console.WriteLine(allPets.Contains(pet));
        }

        internal object AddPet()
        {
            return indexPetName;
        }
        public void RemovePet(Pet pet)
        {
         allPets.Remove(pet);
        }
        
        public void PrintPetStats()
        {
            Console.WriteLine("\n\tList of pets in this shelter");

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
                Console.WriteLine("\n\tYou fed all of your pet!");
            }            
        }

        public void WaterAll()
        {
            foreach (Pet pet in allPets)
            {
                pet.GiveWater();
                Console.WriteLine("\n\tYou gave all of your pets water!");
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
