using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RoboticTest
    {
        public RoboticPet testRPet;
        public RoboticTest()
        {
            testRPet = new RoboticPet();
        }

        [Fact]
        public void Pet_Should_Have_OilLevel()
        {
            Assert.NotNull(testRPet.GetOilLevel()); 
        }
        [Fact]
        public void Pet_Should_Have_Repair()
        {

            Assert.NotNull(testRPet.Repair);
        }

        [Fact]
        public void Pet_Should_Have_Battery()
        {

            Assert.NotNull(testRPet.Battery);
        }

        [Fact]
        public void GetOilLevel_Should_Return_Initial_OilLevel_Level_Of_50()
        {
            int testPetOilLevel = testRPet.GetOilLevel();

            Assert.Equal(50, testPetOilLevel);
        }

        [Fact]
        public void GetRepair_Should_Return_Initial_Maintenance_Level_Of_50()
        {
            int testPetMaintenance = testRPet.GetRepair();

            Assert.Equal(50, testPetMaintenance);
        }

        [Fact]
        public void GiveWater_Should_Increase_OilLevel_By_5()
        {
            testRPet.GiveWater();

            Assert.Equal(55, testRPet.GetOilLevel());
        }

        [Fact]
        public void Feed_Should_Increase_OilLevel_By_20()
        {
            testRPet.Feed();

            Assert.Equal(70, testRPet.GetOilLevel());
        }
        
        [Fact]
        public void SeeDoctor_Should_Increase_Repair_By_5()
        {
        
            testRPet.SeeDoctor();

            Assert.Equal(55, testRPet.GetRepair());
        }

        [Fact]
        public void Play_Should_Decrease_Repair_By_5()
        {

            testRPet.Play();

            Assert.Equal(45, testRPet.GetRepair());
        }

        [Fact]
        public void Play_Should_Increase_OilLevel_By_15()
        {            
            testRPet.Play();

            Assert.Equal(65, testRPet.GetOilLevel());
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_10()
        {
            testRPet.Play();

            Assert.Equal(40, testRPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Increase_OilLevel_By_5()
        {
    
            testRPet.Tick();

            Assert.Equal(55, testRPet.GetOilLevel());
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_10()
        {
          testRPet.Tick();

            Assert.Equal(60, testRPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Decrease_Repair_By_5()
        {
             testRPet.Tick();

            Assert.Equal(45, testRPet.GetRepair());

        }

        [Fact]
        public void Tick_Should_Decrease_Battery_By_10()
        {
            testRPet.Tick();

            Assert.Equal(45, testRPet.GetBattery());

        }
    }
}
