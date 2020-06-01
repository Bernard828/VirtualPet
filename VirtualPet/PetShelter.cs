using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
       public List<Pet> allPetsList = new List<Pet>();
        public int index;
                
       public void AddPet(Pet pet)
       {
            //int[] = allPets.Contains(pet);

            allPetsList.Add(pet);
       }

        public void PrintPetTypes()
        {
            Console.WriteLine("\n\t MASTER LIST of All Pets!!!");

            foreach (Pet pet in allPetsList)
            {
               // Console.WriteLine("\n");
                Console.WriteLine($"aNumber. Name: {pet.Name}");
                Console.WriteLine($"species type: {pet.Species}");
                //Console.WriteLine($"Robotic or Organic:{}");
            }
        }

       //specificPet() job is to select a certain animal bu number, or name

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
        
        public Pet FindAnimalByIndex (int index)
        { Pet selectedPet = allPetsList[index];
            return selectedPet;
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

    }
}
