using System;
using System.ComponentModel;

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

                Console.WriteLine("Hello! Welcome to Virtual Pets\n");
                Console.WriteLine("1. Let's make a new pet");
                Console.WriteLine("2. Feed your animal");
                Console.WriteLine("3. Water is always necesary.");
                Console.WriteLine("4. Bedtime!");
                Console.WriteLine("5. Visit the vet:");
                Console.WriteLine("6. To visit my Pet");
                Console.WriteLine("Press L to leave ");

               

                string userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "1":
                        { 
                            break; 
                        }
                    case "2":
                        {
                            void Feed()
                            {
                                Feed();
                            }
                            break; 
                        }
                    case "3":
                        { break; }
                    case "4":
                        { break; }
                    case "5":
                        { break; }
                    case "6":
                        { break; }
                    case "L":
                        {
                            continuePlay = false;
                            Console.WriteLine("Dont forget to comeback and feed!");
                             break; }
                    default:
                        break;
                }
            }
        Console.WriteLine("Press enter to return to the Main Menu");
        Console.ReadLine();
        }
        
    }
}
