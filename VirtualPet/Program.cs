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

            PetShelter myShelter = new PetShelter();

            Pet newPet = new Pet();

            bool stillPlaying = true;

            while (stillPlaying)
            {
                Console.WriteLine("\nHello! Welcome to Virtual Pets\n");
                Console.WriteLine("1. Bringing in a new pet?");
                Console.WriteLine("2. View list of pets."); 
                Console.WriteLine("3. Select a certain pet.");
                Console.WriteLine("4. Feed your pet(s).");
                Console.WriteLine("5. Give your pet(s) water.");
                Console.WriteLine("6. Your pet(s) bored, let's play.");
                Console.WriteLine("7. Time for a checkup with the vet.");
                Console.WriteLine("8. Adopt a pet!");
                Console.WriteLine("\n Press 'Q' to Exit game.");
                Console.WriteLine("Press enter to return to the Main Menu\n");

                string userChoice = Console.ReadLine().ToLower();
                
            
                switch (userChoice)
                {
                    case "1":

                     newPet = new Pet();

                        newPet.CreatePet();

                        myShelter.AddPet(newPet);    
                        
                        break;

                    case "2":

                       myShelter.PrintPetStats();

                        break;

                    case "3":

                        myShelter.PrintPetStats();

                        break;

                    case "4":

                        Console.WriteLine("Press '1'feed one pet, press '2' fedd all pets.");
                       
                        string feedChoice = Console.ReadLine();

                        switch (feedChoice)
                        {
                            case "1":

                                newPet.Feed();

                                break;

                            case "2":

                                myShelter.FeedAll();

                                break;

                            default:
                                break;
                        }
                        break;

                    case "5":
                        Console.WriteLine($"You gave {newPet.GetName()} some water");

                        newPet.GiveWater();

                        break;

                    case "6":

                        Console.WriteLine($"{newPet.GetName()} enjoyed the exercise.");

                        newPet.Play();

                        break;
                    case "7":

                        Console.WriteLine($" {newPet.GetName()} is feeling much better.");

                        newPet.SeeDoctor();

                        break;
                    case "8":

                        Console.WriteLine("Who do you want to take home with you!");

                        int numberForPet = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($" I know you'll give him a good home!");

                        break;

                    case "q":

                        Console.ReadLine().ToLower();

                        break;

                    default:
                        break;
                }
            }
        }

    }
}
