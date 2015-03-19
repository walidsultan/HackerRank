using HackerRank.Algorithms;
using HackerRank.Algorithms.NumberTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.AlgorithmsTests.NumberTheory
{
    [TestClass]
    public class ReverseGameTests
  {
        [TestMethod]
        public void ReverseGame_Test01()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("NumberTheory\\ReverseGame\\input01.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            ReverseGame reverseGame = new ReverseGame(consoleTester);

            reverseGame.Solve();

            string[] outputData = File.ReadAllText("NumberTheory\\ReverseGame\\output01.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test01 is wrong for test {0}", i));
            }
        }
    }
}
