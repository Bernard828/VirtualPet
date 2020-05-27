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
            string name = Message("name");
            string species = Message("species type");
            DisplayOutput(name, species);
            Console.WriteLine("\nHello! Welcome to Virtual Pets\n");
            Console.WriteLine("What is your pets name:");
            Console.WriteLine("What is your pet's species");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Press enter to return to the Main Menu");

            string userChoice = Console.ReadLine();
            Console.Clear();
        }

               
        public static string Message(string msg)
        {
            Console.WriteLine("Please enter your {0}: ", msg);
            return Console.ReadLine();
        }
        public static void DisplayOutput (string name, string species)
        {
            Console.WriteLine("Your pet's name is {0}", name);
            Console.WriteLine("Your pet's species is {0}", species);
        }
        
    }
}
