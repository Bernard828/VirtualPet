using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
       public List<Pet> allPetsList = new List<Pet>();
                
       public void AddPet(Pet pet)
       {
            //int[] = allPets.Contains(pet);

            allPetsList.Add(pet);

       }

        //internal object AddPet()
        //{
        //    return indexPetName;
        //}
        public void RemovePet(Pet pet)
        {
         allPetsList.Remove(pet);
        }
        public void SpecificPet()
        {
           // allPets."";
        }
        public void PrintPetStats()
        {
            Console.WriteLine("\n\tList of pets in this shelter");

            foreach (Pet pet in allPetsList)
            {
                Console.WriteLine("\n");
              pet.PrintThisPetStats();
            }
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

    }
}
