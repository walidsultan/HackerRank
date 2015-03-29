using HackerRank.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Algorithms.SummationsAndAlgebra;
using System.IO;
using HackerRank.Algorithms._101Hack;
namespace HackerRank.AlgorithmsTests.SummationsAndAlgebra
{
    [TestClass]
    public class DevuAndMinimizingRunsOfAStringTests
    {
        [TestMethod]
        public void DevuAndMinimizingRunsOfAString_Test00()
        {
            string[] testData = { "3", "RB", "RBRR", "RRR" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            DevuAndMinimizingRunsOfAString devuAndMinimizingRunsOfAString = new DevuAndMinimizingRunsOfAString(consoleTester);

            devuAndMinimizingRunsOfAString.Solve();

            Assert.AreEqual( "2",consoleTester._outputBuffer[0], "Test01 is wrong");
            Assert.AreEqual( "2",consoleTester._outputBuffer[1], "Test01 is wrong");
            Assert.AreEqual( "1",consoleTester._outputBuffer[2], "Test01 is wrong");
        }

        [TestMethod]
        public void DevuAndMinimizingRunsOfAString_Test01()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("101Hack\\DevuAndMinimizingRunsOfAString\\input01.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            DevuAndMinimizingRunsOfAString devuAndMinimizingRunsOfAString = new DevuAndMinimizingRunsOfAString(consoleTester);

            devuAndMinimizingRunsOfAString.Solve();

            string[] outputData = File.ReadAllText("101Hack\\DevuAndMinimizingRunsOfAString\\output01.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test01 is wrong for test {0}", i));
            }
        }

        [TestMethod]
        public void DevuAndMinimizingRunsOfAString_Test07()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("101Hack\\DevuAndMinimizingRunsOfAString\\input07.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            DevuAndMinimizingRunsOfAString devuAndMinimizingRunsOfAString = new DevuAndMinimizingRunsOfAString(consoleTester);

            devuAndMinimizingRunsOfAString.Solve();

            string[] outputData = File.ReadAllText("101Hack\\DevuAndMinimizingRunsOfAString\\output07.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test01 is wrong for test {0}", i));
            }
        }

        [TestMethod]
        public void DevuAndMinimizingRunsOfAString_Test02()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("101Hack\\DevuAndMinimizingRunsOfAString\\input02.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            DevuAndMinimizingRunsOfAString devuAndMinimizingRunsOfAString = new DevuAndMinimizingRunsOfAString(consoleTester);

            devuAndMinimizingRunsOfAString.Solve();

            string[] outputData = File.ReadAllText("101Hack\\DevuAndMinimizingRunsOfAString\\output02.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test01 is wrong for test {0}", i));
            }
        }

    }
}
