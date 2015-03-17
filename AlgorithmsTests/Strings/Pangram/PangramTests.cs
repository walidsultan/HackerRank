using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Strings;

namespace HackerRank.AlgorithmsTests.Strings
{
    [TestClass]
    public class PangramTests
    {
        [TestMethod]
        public void PangramTests_Test01()
        {
            string[] testData = { "qmExzBIJmdELxyOFWv LOCmefk TwPhargKSPEqSxzveiun" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            Pangram pangram = new Pangram(consoleTester);

            pangram.Solve();

            Assert.AreEqual("pangram", consoleTester._outputBuffer[0], "Test01 is wrong");
        }
    }
}
