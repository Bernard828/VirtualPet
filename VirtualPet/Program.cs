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
            bool stillPlaying = true;

            Pet newPet = new Pet();
            RoboticPet roboticPet = new RoboticPet();
            OrganicPet organicPet = new OrganicPet();
            PetShelter myShelter = new PetShelter();
                        
            while (stillPlaying)
            {
                Console.WriteLine("\n\tHello! Welcome to Virtual Pets \t\t\t\t"); myShelter.PrintAllPetsList();
                Console.WriteLine($"\nYou are currently interacting with " + newPet.Name +"\n");
                Console.WriteLine("\t1. Bringing in a new pet?");
                Console.WriteLine("\t2. Select a certain pet to interact with.");
                Console.WriteLine("\t3. View list of pets."); 
                Console.WriteLine("\t4. Feed your pet(s).");
                Console.WriteLine("\t5. Give your pet(s) water.");
                Console.WriteLine("\t6. Your pet(s) bored, let's play.");
                Console.WriteLine("\t7. Time for a checkup with the vet.");
                Console.WriteLine("\t8. Adopt a pet!");
                Console.WriteLine("\n\t Press 'Q' to Exit game.");
                Console.WriteLine("\tPress enter to return to the Main Menu\n");

                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();
                
            
                switch (userChoice)
                { 
                    case "1":

                        Console.WriteLine("\tEnter 1' [Organic Pet] or '2' [Robotic Pet].");
                        string petChoice = Console.ReadLine();

                        switch (petChoice)
                        {
                            case "1":
                                myShelter.PrintAllPetsList();
                                organicPet = new OrganicPet();
                                organicPet.CreatePet();
                                myShelter.AddPet(organicPet);
                                break;

                            case "2":
                                myShelter.PrintAllPetsList();
                                roboticPet = new RoboticPet();
                                roboticPet.CreatePet();
                                myShelter.AddPet(roboticPet);
                                break;

                            default:
                                break;
                        }
                        break;

                    case "2":
                        myShelter.PrintAllPetsList();
                        newPet = myShelter.FindAnimalByIndex();
                        break;

                    case "3":

                        myShelter.PrintAllPetsList(); //Create new method add pet stats, next to each pet

                        break;

                    case "4":

                        Console.WriteLine("\tEnter 1' [To feed one pet] or '2' [Feed all pets].");
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
                        }break;

                    case "5":
                        Console.WriteLine("\tPress '1' [To quench one pet's thirst] or press '2' [For all pets].");
                        
                        string thirstChoice = Console.ReadLine();

                        switch (thirstChoice)
                        {
                            case "1":

                                newPet.GiveWater();
                                break;

                            case "2":

                                myShelter.WaterAll();
                                break;

                            default:
                                break;
                        }break;

                    case "6":
                        Console.WriteLine("\tPress '1'[Play with one pet] or press '2' [Play with all pets].");

                        string playChoice = Console.ReadLine();

                        switch (playChoice)
                        {
                            case "1":

                                newPet.Play();
                                break;

                            case "2":

                                myShelter.PlayWithAll();
                                break;

                            default:
                                break;
                        }break;

                    case "7":
                        Console.WriteLine("\tPress '1' [To take one pet] or press '2' [To take all pets].");

                        string healthChoice = Console.ReadLine();
                        Console.Clear();

                        switch (healthChoice)
                        {
                            case "1":

                                newPet.SeeDoctor();
                                break;

                            case "2":

                                myShelter.SeeDoctorAll();
                                break;

                            default:
                                break;
                        }break;

                    case "8":
                        myShelter.PrintAllPetsList();
                        Console.WriteLine("\n\tWho do you want to adopt?");
                        int petName = Convert.ToInt32(Console.ReadLine());
                        Pet  petToRemove = myShelter.FindAnimalByIndex();
                        myShelter.AdoptPet(petToRemove);
                        Console.WriteLine($"You'll make a great pet parent!");
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
