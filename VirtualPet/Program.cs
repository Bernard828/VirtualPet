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
            PetShelter myShelter = new PetShelter();
                        
            while (stillPlaying)
            {
                Console.WriteLine("\n\tHello! Welcome to Virtual Pets\n");
                Console.WriteLine("\t1. Bringing in a new pet?");
                Console.WriteLine("\t2. Select a certain pet.");
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
                { //add Pet
                    case "1":

                     newPet = new Pet();

                        newPet.CreatePet();

                        myShelter.AddPet(newPet);    
                        
                        break;

                    case "2":

                        myShelter.PrintAllPetsList();
                        int numberForPet = Convert.ToInt32(Console.ReadLine());

                        break;

                    case "3":

                       myShelter.PrintPetTypes();

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
                        myShelter.PrintAllPetsList();
                        Console.WriteLine("\n\tWho do you want to adopt?");

                        myShelter.AdoptPet();

                        //int numberForPet = Convert.ToInt32(Console.ReadLine());
                        //myShelter.AdoptPet();
                            //doesnt remove pet yet

                       
                        //Console.WriteLine($"Do you feel responsible enough to give a good home? ('YES'/'NO')");
                        //Console.ReadLine();

                       //Console.WriteLine($"\tI know you'll give {} a good home!");

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
