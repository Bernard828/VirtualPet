using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {


        PetShelter myShelter = new PetShelter();

        [Fact]
        public void AddPet_Should_Include_List_Count_By1()
        {

            int petCount = myShelter.myPets.Count;

            Pet newPet = new Pet("second pet");
            myShelter.AddPet(newPet);

            int newPetCount = myShelter.myPets.Count;
        }
        //public void RemovePet_Removes_Pet_From_List()
        //{
        //    Pet pet = new Pet();

        //    sut.RemovePet(pet);

        //    Assert.DoesNotContain(Pet, sut.PetShelterList);
        //}

        //Count should be original plus 1

        //Assert.Single(sut, ShelterList);
        //[Fact]
        //public void FindPetStatSheetInList_ShouldReturnCurrentPetStats()
        //{

        //    Pet petToRemove -new Pet();
        //    sut.AddPet(petToRemove);
        //    int myPetIndex = sut.CookieOrderList.IndexOf(petToRemove);


        //    Pet returnedFromList = sut.FindCookieOrderByIndeX();


        //    Assert.True(orderToRemove.Equals(reurnedFromList));
        //}

        //[Fact]

        //public void RemoveOrder_Removes_Order_from_List()
        //{
        //    Order order = new Order();
        //    sut.AddOrder(order);

        //    sut
        //    Assert.DoesNotContain(Order, sut.CookieOrderList);

        //}

    }
}