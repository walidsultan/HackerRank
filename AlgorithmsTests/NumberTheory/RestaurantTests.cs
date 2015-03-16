using HackerRank.Algorithms;
using HackerRank.Algorithms.NumberTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.AlgorithmsTests.NumberTheory
{
    [TestClass]
    public class RestaurantTests
    {
        [TestMethod]
        public void Restaurant_Test01()
        {
            string[] testData = { "11", "38 751", "344 734", "165 635", "297 667", "917 264", "544 642", "254 914", "612 50", "94 707", "564 417", "145 246" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            Restaurant restaurant = new Restaurant(consoleTester);

            restaurant.Solve();
            Assert.AreEqual(consoleTester._outputBuffer[0], "28538", "Test01 is wrong");
            Assert.AreEqual(consoleTester._outputBuffer[1], "63124", "Test01 is wrong");
        }
    }
}
