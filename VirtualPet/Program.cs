using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
                     
            
            bool continuePlay = true;
            while (continuePlay)
            {
                pet.Tick();
                Console.WriteLine("\nHello! Welcome to Virtual Pets\n");
                Console.WriteLine("1. Add a new pet.");
                Console.WriteLine($"2. Feed {pet.GetName()}");
                Console.WriteLine($"3. Give {pet.GetName()} some water.");
                Console.WriteLine($"4. {pet.GetName()} tired, time for a nap!");
                Console.WriteLine("5. See the Vet");
                Console.WriteLine($"6. Play with {pet.GetName()}");
                Console.WriteLine("\nPress L to leave ");

                string userChoice = Console.ReadLine().ToLower();
                switch(userChoice)
                {
                    case "1":
                    {
                        pet.GetPetStats();
                        Console.WriteLine($"Say Hi to {pet.GetName()}");
                        Console.WriteLine($"Health: {pet.GetHealth()}");
                        Console.WriteLine($"Hunger: {pet.GetHunger()}");
                        Console.WriteLine($"Thirst: {pet.GetThirst()}");
                        Console.WriteLine($"Sleep: {pet.GetSleep()}");
                        break;
                    }
                    case "2":
                    {
                            pet.Feed();
                            Console.WriteLine($"New Hunger: {pet.GetHunger()}");
                            Console.WriteLine($"I was extremley hungry ");
                            Console.WriteLine("\nThank you for feeding me!!!");
                            
                            break; 
                    }
                    case "3":
                    {
                            pet.GiveWater();
                            Console.WriteLine($"\nThirst:{pet.GetThirst()}");
                            Console.WriteLine("\nThank you! I was really thirsty!!!");
                            
                            break;
                    }
                    case "4":
                    {
                            pet.TakeNap();
                            Console.WriteLine($"\nSleep: {pet.GetSleep()} ");
                            Console.WriteLine("\nGreat I get to sleep that food off now!!!");
                            
                            break;
                    }
                    case "5":
                    {
                            pet.SeeDoctor();
                            Console.WriteLine($"\nHealth: {pet.GetHealth()}");
                            Console.WriteLine("\nWe're lucky to have life insurance!!!");
                            break; 
                    }
                    case "6":
                    {
                        pet.Play();
                        Console.WriteLine($"\n: {pet.GetHunger()}");
                        Console.WriteLine($"\n: {pet.GetThirst()}");
                        Console.WriteLine($"\n: {pet.GetHealth()}");
                        Console.WriteLine("\nThat was so muh fun, that made me hungry");
                        break;
                    }
                    case "l":
                    {
                        continuePlay = false;
                        Console.WriteLine("\nDont forget to come back and adopt!");
                            break; 
                    }
                    default:
                        break;
                }
            }
        Console.WriteLine("Press enter to return to the Main Menu");
        Console.ReadLine();
        }
        
    }
}
