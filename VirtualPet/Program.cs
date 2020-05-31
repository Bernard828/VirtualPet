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
                Console.WriteLine("\n\tHello! Welcome to Virtual Pets\n");
                Console.WriteLine("\t1. Bringing in a new pet?");
                Console.WriteLine("\t2. View list of pets."); 
                Console.WriteLine("\t3. Select a certain pet.");
                Console.WriteLine("\t4. Feed your pet(s).");
                Console.WriteLine("\t5. Give your pet(s) water.");
                Console.WriteLine("\t6. Your pet(s) bored, let's play.");
                Console.WriteLine("\t7. Time for a checkup with the vet.");
                Console.WriteLine("\t8. Adopt a pet!");
                Console.WriteLine("\n\t Press 'Q' to Exit game.");
                Console.WriteLine("\tPress enter to return to the Main Menu\n");

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

                        myShelter.SpecificPet();

                        break;

                    case "4":

                        Console.WriteLine("\tPress '1'feed one pet, press '2' feed all pets.");
                       
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
                        Console.WriteLine("\tPress '1' to quench one pet's thirst , press '2' for all pets.");

                        string thirstChoice = Console.ReadLine();

                        switch (thirstChoice)
                        {
                            case "1":

                                newPet.GiveWater();


                                break;

                            case "2":

                                myShelter.FeedAll();

                                break;

                            default:
                                break;
                        }
                        break;

                    case "6":

                       newPet.Play();

                        break;
                    case "7":

                        newPet.SeeDoctor();

                        break;
                    case "8":

                        Console.WriteLine("\tWho do you want to adopt?");

                        int numberForPet = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"\tI know you'll give {myShelter.AddPet()} a good home!");

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
