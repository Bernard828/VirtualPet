using System;
using System.ComponentModel;
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
                Console.WriteLine("1. To visit my Pet");
                Console.WriteLine("2. Feed your animal");
                Console.WriteLine("3. Water is always necesary.");
                Console.WriteLine("4. Let your pet take a nap!");
                Console.WriteLine("5. Visit the vet:");
                Console.WriteLine("\nPress L to leave ");

               

                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "1":
                    {

                            Console.WriteLine($"\nSay Hi to {pet.Name} ");
                            Console.WriteLine("\nHunger:");
                            Console.WriteLine("\nHealth:");
                            Console.WriteLine("\nThirst:");
                            Console.WriteLine("\nSleep:");
                            break; 
                    }
                    case "2":
                    {
                        pet.Feed();
                            Console.WriteLine("\nHunger: ", hunger);
                            Console.WriteLine("\nThank you for feeding me!!!");
                            break; 
                    }
                    case "3":
                    {
                        pet.GiveWater();
                            Console.WriteLine("\nThirst:  ");
                            Console.WriteLine("\nThank you! I was really thirsty!!!");
                            break;
                    }
                    case "4":
                    {
                        pet.TakeNap();
                            Console.WriteLine("\nSleep:  ");
                            Console.WriteLine("\nGreat I get to sleep that food off now!!!!");
                            break;
                    }
                    case "5":
                    {
                            pet.SeeDoctor();
                            Console.WriteLine("\nSleep:  " );
                            Console.WriteLine("\nWe're lucky to have life insurance!!!");
                            break; 
                    }
                    case "l":
                    {
                        continuePlay = false;
                        Console.WriteLine("\nDont forget to comeback and feed!");
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
