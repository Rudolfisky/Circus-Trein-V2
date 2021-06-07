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
        [TestMethod()]
        public void addWagon_AddNewWagonWithAnimal_Succeed()
        {
            //assign
            Train train = new Train();
            Animal animal = new Animal(Type.Carnivore, Size.Medium);
            //act
            train.addToNewWagon(animal);
            Console.WriteLine(train);
            //assert            
            Assert.IsTrue(train.GetAllWagons().Count() == 1);
            //Assert.Fail();
        }
    }
}