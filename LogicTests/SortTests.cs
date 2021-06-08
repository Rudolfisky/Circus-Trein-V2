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
    public class SortTests
    {
        private Sort _sorter;

        [TestInitialize]
        public void Setup() 
        {
            _sorter = new Sort();
        }

        [TestMethod()]
        public void Start_UseTestDataArrayOnStart_ShouldBeTrue()
        {
            //assign
            int[] animalsArray = { 5, 5, 5, 5, 5, 5};            
            //act
            Train train = _sorter.Start(animalsArray);
            //assert
            Assert.AreEqual(train.GetAllWagons().Count(), 16);
        }
        [TestMethod()]
        public void Start_UseTestDataListOnStart_ShouldBeTrue()
        {
            //assign
            List<Animal> animalsList = MakeAnimalList(5, 5, 5, 5, 5, 5);
            //act
            Train train = _sorter.Start(animalsList);
            //assert
            Assert.AreEqual(train.GetAllWagons().Count(), 16);
        }
        [TestMethod()]
        public void Start_UseTestDataListMixedOnStart_ShouldBeTrue()
        {
            //assign
            List<Animal> animalsList = MakeAnimalListMixed(5, 5, 5, 5, 5, 5);
            //act
            Train train = _sorter.Start(animalsList);
            //assert
            Assert.AreEqual(train.GetAllWagons().Count(), 16);
        }
        private List<Animal> MakeAnimalList(int carnivoreS, int carnivoreM, int carnivoreL, int herbivoreS, int herbivoreM, int herbivoreL) 
        {
            List<Animal> animalsList = new List<Animal>();
            
            for (int i = 0; i < carnivoreS; i++)
            {
                Animal newAnimal = new Animal(Type.Carnivore, Size.Small);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < carnivoreM; i++)
            {
                Animal newAnimal = new Animal(Type.Carnivore, Size.Medium);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < carnivoreL; i++)
            {
                Animal newAnimal = new Animal(Type.Carnivore, Size.Large);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < herbivoreS; i++)
            {
                Animal newAnimal = new Animal(Type.Herbivore, Size.Small);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < herbivoreM; i++)
            {
                Animal newAnimal = new Animal(Type.Herbivore, Size.Medium);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < herbivoreL; i++)
            {
                Animal newAnimal = new Animal(Type.Herbivore, Size.Large);
                animalsList.Add(newAnimal);
            }
            return animalsList;
        }
        private List<Animal> MakeAnimalListMixed(int carnivoreS, int carnivoreM, int carnivoreL, int herbivoreS, int herbivoreM, int herbivoreL)
        {
            List<Animal> animalsList = new List<Animal>();

            for (int i = 0; i < herbivoreM; i++)
            {
                Animal newAnimal = new Animal(Type.Herbivore, Size.Medium);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < carnivoreM; i++)
            {
                Animal newAnimal = new Animal(Type.Carnivore, Size.Medium);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < herbivoreS; i++)
            {
                Animal newAnimal = new Animal(Type.Herbivore, Size.Small);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < carnivoreL; i++)
            {
                Animal newAnimal = new Animal(Type.Carnivore, Size.Large);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < herbivoreL; i++)
            {
                Animal newAnimal = new Animal(Type.Herbivore, Size.Large);
                animalsList.Add(newAnimal);
            }
            for (int i = 0; i < carnivoreS; i++)
            {
                Animal newAnimal = new Animal(Type.Carnivore, Size.Small);
                animalsList.Add(newAnimal);
            }
            return animalsList;
        }

        [TestMethod()]
        public void Start_NoAnimalsInTrain_ShouldBeEmpty()
        {
            //assign
            int[] animals = { 0, 0, 0, 0, 0, 0 };
            //act
            Train train = _sorter.Start(animals);
            //assert
            Assert.AreEqual(train.GetAllWagons().Count(), 0);
        }
    }
}