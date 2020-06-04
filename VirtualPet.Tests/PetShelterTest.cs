using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        public PetShelter myShelter;
        OrganicPet newOrganicPet1;
        OrganicPet newOrganicPet2;



        public ShelterTests()
        {
            myShelter = new PetShelter();
            newOrganicPet1 = new OrganicPet();
            newOrganicPet2 = new OrganicPet();
        }

        [Fact]
        public void AddPet_Should_Include_List_Count_By1()
        {
            int petCount = myShelter.allPetsList.Count;
            Pet newPet = new Pet("second pet");
            myShelter.AddPet(newPet);
            int newPetCount = myShelter.allPetsList.Count;
        }
        [Fact]
        public void Remove_APet()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.AdoptPet(newOrganicPet1);
            Assert.Equal(0, myShelter.allPetsList.Count);
        }

        [Fact]
        public void FeedAll_Method_Should_FeddAll_Pets()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.FeedAll();

            Assert.Equal(55, newOrganicPet1.Hunger);
            Assert.Equal(55, newOrganicPet2.Hunger);
        }
        [Fact]
        public void WaterAll_Method_Should_Increase_By_5()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.WaterAll();

            Assert.Equal(55, newOrganicPet1.Thirst);
            Assert.Equal(55, newOrganicPet2.Thirst);
        }
        [Fact]
        public void SeeDoctorAll_Method_Should_Increase_Health_By_30()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.SeeDoctorAll();

            Assert.Equal(80, newOrganicPet1.Health);
            Assert.Equal(80, newOrganicPet2.Health);
        }

        [Fact]
        public void PlayWithAll_Method_Should_Increase_Hunger_By_10()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.PlayWithAll();

            Assert.Equal(60, newOrganicPet1.Hunger);
            Assert.Equal(60, newOrganicPet2.Hunger);
        }

        [Fact]
        public void PlayWithAll_Shoud_Increase_Thirst_By_20()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.PlayWithAll();

            Assert.Equal(70, newOrganicPet1.Thirst);
            Assert.Equal(70, newOrganicPet2.Thirst);
        }
        [Fact]
        public void PlayWithAll_Shoud_Increase_Health_By_10()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.PlayWithAll();

            Assert.Equal(60, newOrganicPet1.Health);
            Assert.Equal(60, newOrganicPet2.Health);
        }
        [Fact]
        public void PlayWithAll_Shoud_Decrease_Boredom_By_10()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.PlayWithAll();

            Assert.Equal(40, newOrganicPet1.Boredom);
            Assert.Equal(40, newOrganicPet2.Boredom);
        }
        [Fact]
        public void TickOnAllPets_Shoud_Increase_Hunger_By_5()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.TickOnAllPets();

            Assert.Equal(55, newOrganicPet1.Hunger);
            Assert.Equal(55, newOrganicPet2.Hunger);
        }

        [Fact]
        public void TickOnAllPets_Shoud_Increase_Thirst_By_5()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.TickOnAllPets();

            Assert.Equal(55, newOrganicPet1.Thirst);
            Assert.Equal(55, newOrganicPet2.Thirst);
        }
        [Fact]
        public void TickOnAllPets_Shoud_Decrease_Boredom_By_5()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.TickOnAllPets();

            Assert.Equal(55, newOrganicPet1.Boredom);
            Assert.Equal(55, newOrganicPet2.Boredom);
        }

        [Fact]
        public void TickOnAllPets_Shoud_Decrease_Health_By_5()
        {
            myShelter.allPetsList.Add(newOrganicPet1);
            myShelter.allPetsList.Add(newOrganicPet2);

            myShelter.TickOnAllPets();

            Assert.Equal(45, newOrganicPet1.Health);
            Assert.Equal(45, newOrganicPet2.Health);
        }
    }
}
