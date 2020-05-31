using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicPetTest
    {
        private Pet testOPet;
        public OrganicPetTest()
        {
            testOPet = new Pet();
        }
        public void OPet_Populates_NewOPet()
        {
            Assert.NotNull(testOPet);
        }
    }
}
