using System;
using System.ComponentModel;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {
        public static void Main(string[] args)
        {
            PetShelter petShelter;

            bool stillPlaying = true;

            Pet newPet = new Pet();

            while (stillPlaying)
            {
                Console.Clear();
                Console.WriteLine("\nHello! Welcome to Virtual Pets\n");
                Console.WriteLine("1. Bringing in a new pet?");
                Console.WriteLine("2. View list of pets.");
                Console.WriteLine("3. Feed your pet(s).");
                Console.WriteLine("4. Give your pet(s) water.");
                Console.WriteLine("5. Your pet(s) bored, let's play.");
                Console.WriteLine("6. Time for a checkup with the vet.");
                Console.WriteLine("7. Adopt a pet!");
                Console.WriteLine("Press enter to return to the Main Menu");

                string userChoice = Console.ReadLine().ToLower();
                
            
                switch (userChoice)
                {
                    case "1":
                        newPet = new Pet();        
                        
                        Console.WriteLine("Waht is your pet's name?");

                        string name = Console.ReadLine();

                        newPet.SetName(name);

                        Console.WriteLine("Whats the species of your animal");

                        string species = Console.ReadLine();

                        newPet.SetSpecies(species);     
                       
                        break;
                    case "2":
                       newPet.PrintEachPetsStats();
                        break;
                    case "3.":
                        Console.WriteLine($"You fed {newPet.GetName()}");
                        newPet.Feed();                    
                        break;
                    case "4.":
                        Console.WriteLine($"You gave {newPet.GetName()} some water");
                        newPet.GiveWater();
                        break;
                    case "5.":
                        Console.WriteLine($"{newPet.GetName()} enjoyed the exercise.");
                        newPet.Play();
                        break;
                    case "6.":
                        Console.WriteLine($" {newPet.GetName()} is feeling much better.");
                        newPet.SeeDoctor();
                        break;
                    case "7.":
                        Console.WriteLine("Who do you want to take home with you!");
                        myPets.RemovePet() = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($" I know you'll give him a good home!");
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
