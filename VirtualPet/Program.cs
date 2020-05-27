using System;
using System.ComponentModel;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Message("name");
            //string species = Message("species type");
            //DisplayOutput(name, species);


            bool stillPlaying = true;
            while (stillPlaying)
            {
                Console.Clear();
                Console.WriteLine("\nHello! Welcome to Virtual Pets\n");
                Console.WriteLine("1. Bringing in a new pet?");
                Console.WriteLine("2. Feed your pet(s).");
                Console.WriteLine("3. Give your pet(s) water.");
                Console.WriteLine("4. Your pet(s) bored, let's play");
                Console.WriteLine("5. Time for a checkup at with the vet.");
                Console.WriteLine("6.");
                Console.WriteLine("Press enter to return to the Main Menu");

                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "1":
                    Console.WriteLine("What is your pets name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is your pet's species");
                    string species = Console.ReadLine();
                        break;
                    case "2.":
                        Feed();
                        break;
                    case "3.":
                        ();
                        break;
                    case "4.":
                        Play();
                        break;
                    case "5.":
                        SeeDoctor();
                        break;
                    case "6.":
                        ();
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
