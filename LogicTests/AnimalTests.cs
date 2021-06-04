using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void IscompatibleWith_SeeIfMediumCarnivoreIsCompatibleWithLargeHerbivore_ShouldBeTrue()
        {
            //assign
            Animal animalA = new Animal(Type.Carnivore, Size.Medium);
            Animal animalB = new Animal(Type.Herbivore, Size.Large);
            //act
            bool isCompatible = animalA.IscompatibleWith(animalB);
            //assert
            Assert.IsTrue(isCompatible);
        }
        [TestMethod()]
        public void IscompatibleWith_SeeIfMediumCarnivoreIsCompatibleWithMediumHerbivore_ShouldBeFalse()
        {
            //assign
            Animal animalA = new Animal(Type.Carnivore, Size.Medium);
            Animal animalB = new Animal(Type.Herbivore, Size.Medium);
            //act
            bool isCompatible = animalA.IscompatibleWith(animalB);
            //assert
            Assert.IsFalse(isCompatible);
        }
    }
}