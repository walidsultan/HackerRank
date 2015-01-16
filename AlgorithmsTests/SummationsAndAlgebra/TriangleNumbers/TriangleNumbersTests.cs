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
    public class TriangleNumbersTests
    {
        [TestCategory("Triangle Numbers")]
        [TestMethod]
        public void Test01()
        {
            string[] testData = { "2","3","4" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            TriangleNumbers triangleNumbers = new TriangleNumbers(consoleTester);

            triangleNumbers.Solve();
            Assert.AreEqual(consoleTester._outputBuffer[0], "2", "Test01 is wrong");
            Assert.AreEqual(consoleTester._outputBuffer[1], "3", "Test01 is wrong");
        }

        [TestCategory("Triangle Numbers")]
        [TestMethod]
        public void Test03()
        {
            string[] testData = File.ReadAllText("SummationsAndAlgebra\\TriangleNumbers\\Test03.txt").Split('\n');

            ConsoleTester consoleTester = new ConsoleTester(testData);

            TriangleNumbers triangleNumbers = new TriangleNumbers(consoleTester);

            triangleNumbers.Solve();

            string[] outputData = File.ReadAllText("SummationsAndAlgebra\\TriangleNumbers\\output03.txt").Split('\n');

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(consoleTester._outputBuffer[i], outputData[i], string.Format("Test03 is wrong for test {0}", i));
            }
        }
    }
}
