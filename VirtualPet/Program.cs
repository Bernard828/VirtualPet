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
                Console.WriteLine("\t1. Bringing an animal in?");
                Console.WriteLine("\t2. Take home a pet!");
                Console.WriteLine("\t3. View list of pets.");
                Console.WriteLine($"\n\n\tThis is"+ newPet.Name);
                Console.WriteLine("\t4. Select one to meet with.");
                Console.WriteLine("\t5. Feed your pet(s).");
                Console.WriteLine("\t6. Give your pet(s) water.");
                Console.WriteLine("\t7. Your pet(s) bored, let's play.");
                Console.WriteLine("\t8. Time for a checkup with the vet.");
                Console.WriteLine("\n\t Type 'E' to end the game.");
                Console.WriteLine("\tPushing 'ENTER' one too many, results in exiting game.");

                string userChoice = Console.ReadLine().ToLower();
                Console.Clear();
                
            
                switch (userChoice)
                { 
                    case "1":
                        //Create function for organic/robotic pet choice.
                        Console.WriteLine("What type of animal is it?");
                        Console.WriteLine("1. Living Animal");
                        Console.WriteLine("2. Robotic Animal");
                        string petChoice = Console.ReadLine();

                        switch (petChoice)
                        {
                            case "1":
                                organicPet = new OrganicPet();
                                organicPet.CreatePet();
                                myShelter.AddPet(organicPet);
                                break;
                            
                            case "2":
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
                        Console.WriteLine("\n\tWhich animal do you want to take home?");
                        Console.WriteLine("Choose an animal by their number on the list.");
                        Pet petToRemove = myShelter.FindAnimalByIndex();
                        myShelter.AdoptPet(petToRemove);
                        Console.WriteLine(newPet.Name + $"said yes!! You'll make a great pet parent!");
                        //Console.Clear();
                        break;
                        
                    case "3":
                        myShelter.PrintAllPetsList();
                        Console.WriteLine("Choose an animal by the kennel number.");
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
