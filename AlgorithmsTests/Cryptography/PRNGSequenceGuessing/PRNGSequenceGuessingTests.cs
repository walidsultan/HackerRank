using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Cryptography;

namespace HackerRank.AlgorithmsTests.Cryptography
{
    [TestClass]
    public class PRNGSequenceGuessingTests
    {
        [TestMethod]
        public void PRNGSequenceGuessing_Test01()
        {
            string[] testData = { "1", "1374037200 1374123600", "643", "558", "37", "259", "913", "939", "101", "569", "607", "974"};

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PRNGSequenceGuessing prngSequenceGuessing = new PRNGSequenceGuessing(consoleTester);

            prngSequenceGuessing.Solve();

            Assert.AreEqual("1374037200 59 721 676 927 438 714 596 342 537 758", consoleTester._outputBuffer[0], "Test01 is wrong");
        }
    }
}
