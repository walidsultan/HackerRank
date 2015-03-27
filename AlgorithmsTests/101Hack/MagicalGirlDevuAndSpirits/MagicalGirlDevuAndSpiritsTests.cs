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
    public class MagicalGirlDevuAndSpiritsTests
    {
        [TestMethod]
        public void MagicalGirlDevuAndSpirits_Test00()
        {
            string[] testData = { "3", "2", "-1 -2", "3", "1 -2 3", "4", "1 2 3 -7" };
            
            ConsoleTester consoleTester = new ConsoleTester(testData);

            MagicalGirlDevuAndSpirits magicalGirlDevuAndSpirits = new MagicalGirlDevuAndSpirits(consoleTester);

            magicalGirlDevuAndSpirits.Solve();

            Assert.AreEqual( "2",consoleTester._outputBuffer[0], "Test01 is wrong");
            Assert.AreEqual( "She did it!",consoleTester._outputBuffer[1], "Test01 is wrong");
            Assert.AreEqual( "She did it!",consoleTester._outputBuffer[2], "Test01 is wrong");
        }

        [TestMethod]
        public void MagicalGirlDevuAndSpirits_Test01()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("101Hack\\MagicalGirlDevuAndSpirits\\input01.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            MagicalGirlDevuAndSpirits magicalGirlDevuAndSpirits = new MagicalGirlDevuAndSpirits(consoleTester);

            magicalGirlDevuAndSpirits.Solve();

            string[] outputData = File.ReadAllText("101Hack\\MagicalGirlDevuAndSpirits\\output01.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(outputData[i], consoleTester._outputBuffer[i], string.Format("Test01 is wrong for test {0}", i));
            }
        }
    }
}
