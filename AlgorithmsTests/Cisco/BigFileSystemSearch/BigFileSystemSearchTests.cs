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
using HackerRank.Algorithms.Cisco;
namespace HackerRank.AlgorithmsTests.SummationsAndAlgebra
{
    [TestClass]
    public class BigFileSystemSearchTests
    {
        [TestMethod]
        public void BigFileSystemSearch_Test00()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("Cisco\\BigFileSystemSearch\\input00.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            BigFileSystemSearch bigFileSystemSearch = new BigFileSystemSearch(consoleTester);

            bigFileSystemSearch.Solve();

            string[] outputData = File.ReadAllText("Cisco\\BigFileSystemSearch\\output00.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test00 is wrong for test {0}", i));
            }
        }

        [TestMethod]
        public void BigFileSystemSearch_Test01()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("Cisco\\BigFileSystemSearch\\input01.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            BigFileSystemSearch bigFileSystemSearch = new BigFileSystemSearch(consoleTester);

            bigFileSystemSearch.Solve();

            string[] outputData = File.ReadAllText("Cisco\\BigFileSystemSearch\\output01.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test01 is wrong for test {0}", i));
            }
        }
    }
}
