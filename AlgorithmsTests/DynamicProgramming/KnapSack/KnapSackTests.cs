using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.DynamicProgramming;

namespace HackerRank.AlgorithmsTests.DynamicProgramming
{
    [TestClass]
    public class KnapSackTests
    {
        [TestMethod]
        public void KnapSack_Test01()
        {
            string[] testData = { "2", "3 12", "1 6 9", "5 9", "3 4 4 4 8" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            KnapSack knapSack = new KnapSack(consoleTester);

            knapSack.Solve();
            Assert.AreEqual(consoleTester._outputBuffer[0], "12", "Test01 is wrong");
            Assert.AreEqual(consoleTester._outputBuffer[1], "9", "Test01 is wrong");
        }
    }
}
