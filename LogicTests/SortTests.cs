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
        [TestMethod()]
        public void Start_UseTestDataOnStart_ShouldBeTrue()
        {
            //assign
            Sort sorter = new Sort();
            int[] animals = { 5, 5, 5, 5, 5, 5};
            //act
            Train train = sorter.Start(animals);
            //assert
            Assert.IsTrue(train.GetAllWagons().Count() == 16);
        }
    }
}