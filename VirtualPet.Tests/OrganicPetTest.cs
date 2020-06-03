using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicPetTest
    {
        public OrganicPet testOPet;
        public OrganicPetTest()
        {
            testOPet = new OrganicPet();
        }
        [Fact]
        public void OPet_Populates_NewOPet()
        {
            Assert.NotNull(testOPet);
        }
        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            Assert.NotNull(testOPet.GetHunger());
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = testOPet.GetHunger();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Thirst()
        {
            Assert.NotNull(testOPet.Thirst);
        }

        [Fact]
        public void GetThirst_Should_Return_Initial_Thirst_Level_Of_50()
        {
            int testPetThirst = testOPet.GetThirst();

            Assert.Equal(50, testPetThirst);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {

            Assert.NotNull(testOPet.Health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_50()
        {
            int testPetHealth = testOPet.GetHealth();

            Assert.Equal(50, testPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_5()
        {
            testOPet.Feed();

            Assert.Equal(55, testOPet.GetHunger());
        }

        [Fact]
        public void GiveWater_Should_Decrease_Thirst_By_5()
        {
            testOPet.GiveWater();

            Assert.Equal(55, testOPet.GetThirst());
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            testOPet.GetHealth();

            testOPet.SeeDoctor();

            Assert.Equal(80, testOPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testOPet.GetHunger();

            testOPet.Play();

            Assert.Equal(60, testOPet.GetHunger());
        }

        [Fact]
        public void Play_Should_Increase_Thirst_By_20()
        {
            testOPet.GetThirst();

            testOPet.Play();

            Assert.Equal(70, testOPet.GetThirst());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            testOPet.GetHealth();

            testOPet.Play();

            Assert.Equal(60, testOPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_10()
        {
            testOPet.Play();

            Assert.Equal(40, testOPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            testOPet.GetHunger();

            testOPet.Tick();

            Assert.Equal(55, testOPet.GetHunger());
        }

        [Fact]
        public void Tick_Should_Increase_Thirst_By_5()
        {
            testOPet.GetThirst();

            testOPet.Tick();

            Assert.Equal(55, testOPet.GetThirst());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            testOPet.GetHealth();

            testOPet.Tick();

            Assert.Equal(45, testOPet.GetHealth());

        }
    }
}
