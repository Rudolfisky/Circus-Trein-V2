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
    public class TrainTests
    {
        private Train _train;
        [TestInitialize]
        public void Setup()
        {
            _train = new Train();
        }
        [TestMethod()]
        public void addWagon_AddNewWagonWithAnimal_Succeed()
        {
            //assign
            Animal animal = new Animal(Type.Carnivore, Size.Medium);
            //act
            _train.addToNewWagon(animal);
            Console.WriteLine(_train);
            //assert            
            Assert.IsTrue(_train.GetAllWagons().Count() == 1);
            //Assert.Fail();
        }
    }
}