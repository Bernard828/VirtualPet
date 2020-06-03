using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class RoboticPet :Pet
    {
        public int Maintenance { get; set; }
        public int OilLevel { get; set; }

        public RoboticPet() : base()
        {
            Maintenance = 50;
            OilLevel = 50;
        }
        public int GetMaintenance()
        {
            return Maintenance ;
        }
        public int GetOilLevel()
        {
            return OilLevel;
        }
      
        public override void CreatePet()
        {
            Console.WriteLine("\n\tWhat's the animal's name?");

            string name = Console.ReadLine();

            SetName(name);

            Console.WriteLine("\n\tWhat type of animal?");

            string species = "Robo- " + Console.ReadLine();

            SetSpecies(species);
        }
        public override void GiveWater()
        {
            this.OilLevel += 5;
            Console.WriteLine($"\tYou oiled {Name} now. Oil Level: {OilLevel}");
        }
        public override void Feed()
        {
            this.OilLevel += 20;
            Console.WriteLine($"\tYou fed {Name} now. Oil Level: {OilLevel}");
        }

        public override void SeeDoctor()
        {
            this.Maintenance += 5;
            Console.WriteLine($"\tYou fixed-up  {Name} now. Maintenance Level: {Maintenance}");
        }


        public override void Play()
        {
            this.Maintenance -= 5;
            this.OilLevel += 15;
            this.Boredom -= 10;
            Console.WriteLine($"\n\t{Name}: 'That was fun!' " +
                $"\tMaintenance:{Maintenance}| Oil Level:{OilLevel}| Boredom:{Boredom}");

        }
        public override void Tick()
        {
            this.Maintenance -= 5;
            this.OilLevel -= 15;
            this.Boredom += 10;
        }

        public override void PrintThisPetStats()
        {
            Console.WriteLine($"\t Pet:{Name} | Boredom:{Boredom} | Maintenance:{Maintenance}| Oil Level {OilLevel} |");
        }
    }
}
