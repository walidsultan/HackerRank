using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Strings;
using System.IO;

namespace HackerRank.AlgorithmsTests.Strings
{
    [TestClass]
    public class TwoStringsTests
    {
        [TestMethod]
        public void TwoStringsTests_Test03()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("Strings\\TwoStrings\\input03.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            TwoStrings twoStrings = new TwoStrings(consoleTester);

            twoStrings.Solve();

            string[] outputData = File.ReadAllText("Strings\\TwoStrings\\output03.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(consoleTester._outputBuffer[i], outputData[i], string.Format("Test03 is wrong for test {0}", i));
            }
        }
    }
}
