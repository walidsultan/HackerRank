using HackerRank.Algorithms;
using HackerRank.Algorithms.Greedy;
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
    public class PriyankaAndToysTests
  {
        [TestMethod]
        public void PriyankaAndToys_Test00()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("Greedy\\PriyankaAndToys\\input01.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PriyankaAndToys priyankaAndToys = new PriyankaAndToys(consoleTester);

            priyankaAndToys.Solve();

            string[] outputData = File.ReadAllText("Greedy\\PriyankaAndToys\\output01.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test00 is wrong for test {0}", i));
            }
        }
    }
}
