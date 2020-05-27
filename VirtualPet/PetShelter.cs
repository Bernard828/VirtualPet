using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public List<Pet> myPets = new List<Pet>();


        ///This is a constructor, because the public "PetShelter" is the same asa hte class name and has no return type... The constructor will return an instance of this class
        public PetShelter()
        {
            //This will automatically add the first pet
            Pet newPet = new Pet("Fido");
            myPets.Add(newPet);

        }

        public void AddPet(Pet pet)
        {
            myPets.Add(pet);
        }
        
        public void RemovePet()
        {
           
        }
        
        public void PrntPetStats()
        {
            Console.WriteLine("List of pets in this shelter");
            foreach (Pet pet in myPets)
            {
              pet.PrintEachPetsStats();
            }
        }
    }
}
