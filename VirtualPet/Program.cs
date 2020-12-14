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
                //Rearange Numbering in Switch case to match the reordered menu
                //myShelter.TickOnAllPets();
                Console.WriteLine("\n\tHello! Welcome to Virtual Pets");
                Console.WriteLine($"\n\n\tYou are currently interacting with " + newPet.Name);
                Console.WriteLine("\t1. Adopt a pet!");  //8
                Console.WriteLine("\t2. Bringing in a new pet?"); //2
                Console.WriteLine("\t3. Select a certain pet to interact with."); //3
                Console.WriteLine("\t4. View list of pets.");  //1
                Console.WriteLine("\t5. Feed your pet(s)."); //4
                Console.WriteLine("\t6. Give your pet(s) water."); //5
                Console.WriteLine("\t7. Your pet(s) bored, let's play."); //6
                Console.WriteLine("\t8. Time for a checkup with the vet."); //7
                Console.WriteLine("\n\t Type 'Q' to end the game."); //Change 'Q' to 'E'
                Console.WriteLine("\tPress enter to return to the Main Menu");

                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();
                
            
                switch (userChoice)
                { 
                    case "1":
                        myShelter.PrintAllPetsList();
                        Console.WriteLine("\n\tWho do you want to adopt?");
                        Pet petToRemove = myShelter.FindAnimalByIndex();
                        myShelter.AdoptPet(petToRemove);
                        Console.WriteLine(newPet.Name + $"said yes!! You'll make a great pet parent!");

                        //myShelter.PrintAllPetsList();
                        //Console.Clear();
                    break;
                        

                    case "2":

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
                        

                    case "3":
                        myShelter.PrintAllPetsList();
                        Console.WriteLine("Select pet by number to view.");
                        newPet = myShelter.FindAnimalByIndex();
                        break;

                    case "4":

                        myShelter.PrintAllPetsList();
                        Console.Clear();

                       // Console.WriteLine("\tEnter 1' [To feed one pet] or '2' [Feed all pets].");
                       //string feedChoice = Console.ReadLine();

                       // switch (feedChoice)
                       // {
                       //     case "1":

                       //         newPet.Feed();
                       //         Console.WriteLine($"\tYou fed {newPet.Name}");
                       //         break;

                       //     case "2":

                       //         myShelter.FeedAll();
                       //         Console.WriteLine($"\tYou fed all the animals in the shelter!");
                       //         break;

                       //     default:
                       //         break;
                       // }
                        break;

                    case "5":

                        Console.WriteLine("\tEnter 1' [To feed one pet] or '2' [Feed all pets].");
                       string feedChoice = Console.ReadLine();

                        switch (feedChoice)
                        {
                            case "1":

                                newPet.Feed();
                                Console.WriteLine($"\tYou fed {newPet.Name}");
                                break;

                            case "2":

                                myShelter.FeedAll();
                                Console.WriteLine($"\tYou fed all the animals in the shelter!");
                                break;

                            default:
                                break;
                        }
                        break;

                        //Console.WriteLine("\tPress '1' [To quench one pet's thirst] or press '2' [For all pets].");
                        
                        //string thirstChoice = Console.ReadLine();

                        //switch (thirstChoice)
                        //{
                        //    case "1":

                        //        newPet.GiveWater();
                        //        Console.WriteLine($"\tYou gave {newPet.Name} somthing to drink");
                        //        break;

                        //    case "2":

                        //        myShelter.WaterAll();
                        //        Console.WriteLine($"\tYou gave all your animals something to drink.");
                        //        break;

                        //    default:
                        //        break;
                        //}
                        

                    case "6":

                        Console.WriteLine("\tPress '1' [To quench one pet's thirst] or press '2' [For all pets].");

                        string thirstChoice = Console.ReadLine();

                        switch (thirstChoice)
                        {
                            case "1":

                                newPet.GiveWater();
                                Console.WriteLine($"\tYou gave {newPet.Name} somthing to drink");
                                break;

                            case "2":

                                myShelter.WaterAll();
                                Console.WriteLine($"\tYou gave all your animals something to drink.");
                                break;

                            default:
                                break;
                        }
                        break;

                        //Console.WriteLine("\tPress '1'[Play with one pet] or press '2' [Play with all pets].");

                        //string playChoice = Console.ReadLine();

                        //switch (playChoice)
                        //{
                        //    case "1":

                        //        newPet.Play();
                        //        Console.WriteLine($"\tYou played with {newPet.Name}");
                        //        break;

                        //    case "2":

                        //        myShelter.PlayWithAll();
                        //        Console.WriteLine($"\tYou played with all the animals.");
                        //        break;

                        //    default:
                        //        break;
                        //}
                        //break;

                    case "7":

                        Console.WriteLine("\tPress '1'[Play with one pet] or press '2' [Play with all pets].");

                        string playChoice = Console.ReadLine();

                        switch (playChoice)
                        {
                            case "1":

                                newPet.Play();
                                Console.WriteLine($"\tYou played with {newPet.Name}");
                                break;

                            case "2":

                                myShelter.PlayWithAll();
                                Console.WriteLine($"\tYou played with all the animals.");
                                break;

                            default:
                                break;
                        }
                        break;

                        //Console.WriteLine("\tPress '1' [To take one pet] or press '2' [To take all pets].");

                        //string healthChoice = Console.ReadLine();
                        //Console.Clear();

                        //switch (healthChoice)
                        //{
                        //    case "1":

                        //        newPet.SeeDoctor();
                        //        Console.WriteLine($"{ newPet.Name} is feeling much better!");
                        //        break;

                        //    case "2":

                        //        myShelter.SeeDoctorAll();
                        //        break;

                        //    default:
                        //        break;
                        //}break;

                    case "8":

                        Console.WriteLine("\tPress '1' [To take one pet] or press '2' [To take all pets].");

                        string healthChoice = Console.ReadLine();
                        Console.Clear();

                        switch (healthChoice)
                        {
                            case "1":

                                newPet.SeeDoctor();
                                Console.WriteLine($"{ newPet.Name} is feeling much better!");
                                break;

                            case "2":

                                myShelter.SeeDoctorAll();
                                break;

                            default:
                                break;
                        }
                        break;

                        //myShelter.PrintAllPetsList();
                        //Console.WriteLine("\n\tWho do you want to adopt?");
                        //Pet  petToRemove = myShelter.FindAnimalByIndex();
                        //myShelter.AdoptPet(petToRemove);
                        //Console.WriteLine(newPet.Name + $"said yes!! You'll make a great pet parent!");
                        //break;

                    case "e":

                        Console.ReadLine().ToLower();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
