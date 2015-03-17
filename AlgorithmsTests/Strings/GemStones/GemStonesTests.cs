using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Strings;
using System.IO;

namespace HackerRank.AlgorithmsTests.Strings
{
    [TestClass]
    public class GemStonesTests
    {
        [TestMethod]
        public void GemStones_Test01()
        {
            string[] testData = { "3", "abcdde", "baccd", "eeabg" };
            
            ConsoleTester consoleTester = new ConsoleTester(testData);

            GemStones gemStones = new GemStones(consoleTester);

            gemStones.Solve();

            Assert.AreEqual("2", consoleTester._outputBuffer[0], "Test01 is wrong");
        }

        [TestMethod]
        public void GemStones_Test00()
        {
            string[] stringSeparators = new string[] { "\n" };
            string[] testData = File.ReadAllText("Strings\\GemStones\\input00.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            GemStones gemStones = new GemStones(consoleTester);

            gemStones.Solve();

            string[] outputData = File.ReadAllText("Strings\\GemStones\\output00.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(consoleTester._outputBuffer[i], outputData[i], string.Format("Test00 is wrong for test {0}", i));
            }
        }
    }
}
