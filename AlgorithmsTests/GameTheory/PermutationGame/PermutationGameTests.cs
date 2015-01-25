using HackerRank.Algorithms;
using HackerRank.Algorithms.GameTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.AlgorithmsTests.GameTheory
{
    [TestClass]
    public class PermutationGameTests
    {
        [TestMethod]
        public void PermutationGameTests_Test01()
        {
            string[] testData = { "2", "3", "1 3 2", "5", "5 3 2 1 4" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PermutationGame permutationGame = new PermutationGame(consoleTester);

            permutationGame.Solve();
            Assert.AreEqual(consoleTester._outputBuffer[0], "Alice", "Test01 is wrong");
            Assert.AreEqual(consoleTester._outputBuffer[1], "Bob", "Test01 is wrong");
        }

        [TestMethod]
        public void PermutationGameTests_Test02()
        {
            string[] testData = File.ReadAllText("GameTheory\\PermutationGame\\Test02.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PermutationGame permutationGame = new PermutationGame(consoleTester);

            permutationGame.Solve();
            string[] outputData = File.ReadAllText("GameTheory\\PermutationGame\\output02.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int wrong = 0;
            for (int i = 0; i < outputData.Length; i++)
            {
                if(consoleTester._outputBuffer[i]!=outputData[i])
                {
                    wrong++;
                }
               // Assert.AreEqual(consoleTester._outputBuffer[i], outputData[i], string.Format("Test02 is wrong for test {0}", i));
            }
        }
    }
}
