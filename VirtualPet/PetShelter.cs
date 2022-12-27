using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class PetShelter
    {
        public bool OrganicPet { get; set; }
        public bool Robotic { get; set; }
        //public List OrganicList { get; set; }
        //public List RoboticList { get; set; }

        public List<Pet> allPetsList = new List<Pet>();
        public List<RoboticPet> roboList = new List<RoboticPet>();
        public List<OrganicPet> orgList = new List<OrganicPet>();

        public PetShelter() { }

        public void AddPet(Pet pet)
        {
            allPetsList.Add(pet);
        }

        public void PrintAllPetsList()
        {
            int listnumber = 1;
            Console.WriteLine("\t No.| \t Name \t |  Species");

            foreach (Pet pet in allPetsList)
            {
                string Name = pet.GetName();
                string Species = pet.GetSpecies();
                Console.WriteLine($"\t {listnumber}. |\t{Name}\t|| {Species}");
                listnumber++;
            }
        }

        public void PrintAllPetsStats()
        {
            int listnumber = 1;
            Console.WriteLine("\t No.|\tName\t||  Species");

            foreach (OrganicPet organicPet in allPetsList)
            {
                string Name = organicPet.GetName();
                string Species = organicPet.GetSpecies();
                int Health = organicPet.GetHealth();

                Console.WriteLine($"\t {listnumber}. |\t{Name}\t|| {Species}| Life ({Health})/ ");
                listnumber++;
            }
        }

        public Pet FindAnimalByIndex()// breaks when exit without entry
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
            foreach (Pet roboticPet in allPetsList)
            {
                roboticPet.Feed();
            }
            foreach (Pet organicPet in allPetsList)
            {
                organicPet.Feed();
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
            foreach (Pet pet in allPetsList)
            {
                pet.Tick();
            }
        }
    }
}
