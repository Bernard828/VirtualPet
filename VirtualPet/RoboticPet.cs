using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet :Pet
    {
        public int Repair { get; set; }
        public int OilLevel { get; set; }
        public int Battery { get; set; }

        public RoboticPet() : base()
        {
            Repair = 50;
            OilLevel = 50;
            Battery = 100;
        }
        public int GetRepair()
        {
            return Repair ;
        }
        public int GetOilLevel()
        {
            return OilLevel;
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
            this.Repair += 5;
            Console.WriteLine($"\tYou fixed-up  {Name} now. Repaired: {Repair}");
        }


        public override void Play()
        {
            this.Repair -= 5;
            this.OilLevel += 15;
            this.Boredom -= 10;
            Console.WriteLine($"\n\t{Name}: 'That was fun!' " +
                $"\tRepair:{Repair}| Oil Level:{OilLevel}| Boredom:{Boredom}");

        }
        public override void Tick()
        {
            this.Repair -= 5;
            this.OilLevel += 5;
            this.Boredom += 10;
            this.Battery -= 10;

            Console.WriteLine($"\n\t{Name}:" +
            $"\t Repair ({Repair})| Oil Level ({OilLevel})| Battery Life:{Battery}| Boredom:{Boredom}");
        }

        public override void PrintThisPetStats()
        {
            Console.WriteLine($"\t Pet:{Name} | Boredom:{Boredom} | Repair:{Repair}| Oil Level {OilLevel} |");
        }
        public override void CreatePet()
        {
            Console.WriteLine("\n\tWhat's the animal's name?");

            string name = Console.ReadLine();

            SetName(name);

            Console.WriteLine("\n\tWhat type of animal?");

            string species = "Robo" + Console.ReadLine();

            SetSpecies(species);
        }
    }
}
