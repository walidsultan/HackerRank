using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Strings;
using System.IO;

namespace HackerRank.AlgorithmsTests.Strings
{
    [TestClass]
    public class SherlockAndAnagramsTests
    {
        [TestMethod]
        public void SherlockAndAnagrams_Test01()
        {
            string[] testData = { "2", "abba", "abcd" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            SherlockAndAnagrams sherlockAndAnagrams = new SherlockAndAnagrams(consoleTester);

            sherlockAndAnagrams.Solve();

            Assert.AreEqual("4", consoleTester._outputBuffer[0], "Test01 is wrong");
            Assert.AreEqual("0", consoleTester._outputBuffer[1], "Test01 is wrong");
        }

        [TestMethod]
        public void SherlockAndAnagrams_Test02()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("Strings\\SherlockAndAnagrams\\input01.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            SherlockAndAnagrams sherlockAndAnagrams = new SherlockAndAnagrams(consoleTester);

            sherlockAndAnagrams.Solve();

            string[] outputData = File.ReadAllText("Strings\\SherlockAndAnagrams\\output01.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test02 is wrong for test {0}", i));
            }
        }
    }
}
