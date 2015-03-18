using HackerRank.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Algorithms.SummationsAndAlgebra;
using System.IO;
namespace HackerRank.AlgorithmsTests.SummationsAndAlgebra
{
    [TestClass]
    public class SummingTheNSeriesTests
    {
        [TestMethod]
        public void TriangleNumbers_Test03()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("SummationsAndAlgebra\\SummingTheNSeries\\input03.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            SummingTheNSeries summingTheNSeries = new SummingTheNSeries(consoleTester);

            summingTheNSeries.Solve();

            string[] outputData = File.ReadAllText("SummationsAndAlgebra\\SummingTheNSeries\\output03.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test03 is wrong for test {0}", i));
            }
        }
        [TestMethod]
        public void TriangleNumbers_Test05()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("SummationsAndAlgebra\\SummingTheNSeries\\input05.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            SummingTheNSeries summingTheNSeries = new SummingTheNSeries(consoleTester);

            summingTheNSeries.Solve();

            string[] outputData = File.ReadAllText("SummationsAndAlgebra\\SummingTheNSeries\\output05.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test05 is wrong for test {0}", i));
            }
        }
    }
}
