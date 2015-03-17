using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Strings;
using System.IO;

namespace HackerRank.AlgorithmsTests.Strings
{
    [TestClass]
    public class PalindromeIndexTests
    {
        [TestMethod]
        public void PalindromeIndex_Test01()
        {
            string[] testData = { "3", "aaab", "baa", "aaa" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PalindromeIndex palindromeIndex = new PalindromeIndex(consoleTester);

            palindromeIndex.Solve();

            Assert.AreEqual("3", consoleTester._outputBuffer[0], "Test01 is wrong");
            Assert.AreEqual("0", consoleTester._outputBuffer[1], "Test01 is wrong");
            Assert.AreEqual("-1", consoleTester._outputBuffer[2], "Test01 is wrong");
        }

        [TestMethod]
        public void PalindromeIndex_Test02()
        {
            string[] testData = { "10", "quyjjdcgsvvsgcdjjyq", "hgygsvlfwcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcflvsgygh", "fgnfnidynhxebxxxfmxixhsruldhsaobhlcggchboashdlurshxixmfxxxbexhnydinfngf", "bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb", "fvyqxqxynewuebtcuqdwyetyqqisappmunmnldmkttkmdlnmnumppasiqyteywdquctbeuwenyxqxqyvf", "mmbiefhflbeckaecprwfgmqlydfroxrblulpasumubqhhbvlqpixvvxipqlvbhqbumusaplulbrxorfdylqmgfwrpceakceblfhfeibmm", "tpqknkmbgasitnwqrqasvolmevkasccsakvemlosaqrqwntisagbmknkqpt", "lhrxvssvxrhl", "prcoitfiptvcxrvoalqmfpnqyhrubxspplrftomfehbbhefmotfrlppsxburhyqnpfmqlaorxcvtpiftiocrp", "kjowoemiduaaxasnqghxbxkiccikxbxhgqnsaxaaudimeowojk" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PalindromeIndex palindromeIndex = new PalindromeIndex(consoleTester);

            palindromeIndex.Solve();

            Assert.AreEqual("1", consoleTester._outputBuffer[0], "Test02 is wrong");
            Assert.AreEqual("8", consoleTester._outputBuffer[1], "Test02 is wrong");
            Assert.AreEqual("33", consoleTester._outputBuffer[2], "Test02 is wrong");
            Assert.AreEqual("23", consoleTester._outputBuffer[3], "Test02 is wrong");
            Assert.AreEqual("24", consoleTester._outputBuffer[4], "Test02 is wrong");
            Assert.AreEqual("43", consoleTester._outputBuffer[5], "Test02 is wrong");
            Assert.AreEqual("20", consoleTester._outputBuffer[6], "Test02 is wrong");
            Assert.AreEqual("-1", consoleTester._outputBuffer[7], "Test02 is wrong");
            Assert.AreEqual("14", consoleTester._outputBuffer[8], "Test02 is wrong");
            Assert.AreEqual("-1", consoleTester._outputBuffer[9], "Test02 is wrong");
        }

        [TestMethod]
        public void PalindromeIndex_Test10()
        {
            string[] testData = File.ReadAllText("Strings\\PalindromeIndex\\input10.txt").Split('\n');

            ConsoleTester consoleTester = new ConsoleTester(testData);

            PalindromeIndex palindromeIndex = new PalindromeIndex(consoleTester);

            palindromeIndex.Solve();

            string[] outputData = File.ReadAllText("Strings\\PalindromeIndex\\output10.txt").Split('\n');

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(consoleTester._outputBuffer[i], outputData[i], string.Format("Test10 is wrong for test {0}", i));
            }
        }
    }
}
