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
    public class JoiningByteBlocksTests
    {
        [TestMethod]
        public void JoiningByteBlocks_Test00()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("Cisco\\JoiningByteBlocks\\input00.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            JoiningByteBlocks joiningByteBlocks = new JoiningByteBlocks(consoleTester);

            joiningByteBlocks.Solve();

            string[] outputData = File.ReadAllText("Cisco\\JoiningByteBlocks\\output00.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test00 is wrong for test {0}", i));
            }
        }
    }
}
