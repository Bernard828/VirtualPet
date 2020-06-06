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
        public int GetBattery()
        {
            return Battery;
        }
      
        public override void GiveWater()
        {
            this.OilLevel += 5;
            Console.WriteLine($"\t{Name}'s new oil level: {OilLevel}");
        }
        public override void Feed()
        {
            this.OilLevel += 20;
            Console.WriteLine($"\t{Name}'s new oil level: {OilLevel}");
        }

        public override void SeeDoctor()
        {
            this.Repair += 5;
            Console.WriteLine($"\t{Name}'s new repair status: {Repair}");
        }

        public override void Play()
        {
            this.Repair -= 5;
            this.OilLevel += 15;
            this.Boredom -= 10;
            Console.WriteLine($"\n\t{Name}\tRepair:{Repair}| Oil Level:{OilLevel}| Boredom:{Boredom}");

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
                int listnumber = 1;
                    listnumber++;

          Console.WriteLine($"\t{listnumber}.  |\t{Name}\t||Battery Level:({Battery}|Boredom:{Boredom}|Repair:{Repair}|Oil Level:{OilLevel}|{Species}|");
        }
        public override void CreatePet()
        {
            Console.WriteLine("\n\tWhat's the animal's name?");

            string name = Console.ReadLine().ToUpper();

            SetName(name);

            Console.WriteLine("\n\tWhat type of animal?");

            string species = "Robo"+ Console.ReadLine();

            SetSpecies(species);
        }
    }
}
