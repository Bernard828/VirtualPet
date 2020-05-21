using System;
using System.ComponentModel;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            int[] petStats = new int[4];
            petStats[0] = 50;
            petStats[1] = 30;
            petStats[2] = 50;
            petStats[3] = 80;

            bool continuePlay = true;
            while (continuePlay)
            {
                pet.Tick();

                Console.WriteLine("Hello! Welcome to Virtual Pets\n");
                Console.WriteLine("1. To visit my Pet");
                Console.WriteLine("2. Feed your animal");
                Console.WriteLine("3. Water is always necesary.");
                Console.WriteLine("4. Let your pet take a nap!");
                Console.WriteLine("5. Visit the vet:");
                
                Console.WriteLine("Press L to leave ");

               

                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "1":
                    {

                            Console.WriteLine($"Say Hi to {pet}");
                            Console.WriteLine("Hunger:" + petStats[0]);
                            //Console.WriteLine($"Health: {b}");
                            //Console.WriteLine($"Thirst: {c}");
                            //Console.WriteLine($"Sleepines: {d}");
                            //Convert
                            //pet.Hunger = a;
                            //pet.Health = b;
                            //pet.Thirst = c;
                            //pet.Sleepiness


                            break; 
                    }
                    case "2":
                    {
                        pet.Feed();
                        break; 
                    }
                    case "3":
                    {
                        pet.GiveWater();
                        break;
                    }
                    case "4":
                    {
                        pet.TakeNap();
                        break;
                    }
                    case "5":
                    {
                        pet.SeeDoctor();
                        break; 
                    }
                    case "l":
                    {
                        continuePlay = false;
                        Console.WriteLine("Dont forget to comeback and feed!");
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
