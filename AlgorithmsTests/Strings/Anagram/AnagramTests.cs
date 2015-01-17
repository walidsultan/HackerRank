using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.Algorithms;
using HackerRank.Algorithms.Strings;

namespace HackerRank.AlgorithmsTests.Strings
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void AnagramTests_Test01()
        {
            string[] testData = { "5", "aaabbb", "ab", "abc", "mnop", "xyyx" };

            ConsoleTester consoleTester = new ConsoleTester(testData);

            Anagram anagram = new Anagram(consoleTester);

            anagram.Solve();

            Assert.AreEqual("3", consoleTester._outputBuffer[0], "Test01 is wrong");
            Assert.AreEqual("1", consoleTester._outputBuffer[1], "Test01 is wrong");
            Assert.AreEqual("-1", consoleTester._outputBuffer[2], "Test01 is wrong");
            Assert.AreEqual("2", consoleTester._outputBuffer[3], "Test01 is wrong");
            Assert.AreEqual("0", consoleTester._outputBuffer[4], "Test01 is wrong");
        }

        [TestMethod]
        public void AnagramTests_Test02()
        {
            string[] testData = {  "10",
"hhpddlnnsjfoyxpciioigvjqzfbpllssuj",
"xulkowreuowzxgnhmiqekxhzistdocbnyozmnqthhpievvlj",
"dnqaurlplofnrtmh",
"aujteqimwfkjoqodgqaxbrkrwykpmuimqtgulojjwtukjiqrasqejbvfbixnchzsahpnyayutsgecwvcqngzoehrmeeqlgknnb",
"lbafwuoawkxydlfcbjjtxpzpchzrvbtievqbpedlqbktorypcjkzzkodrpvosqzxmpad",
"drngbjuuhmwqwxrinxccsqxkpwygwcdbtriwaesjsobrntzaqbe",
"ubulzt",
"vxxzsqjqsnibgydzlyynqcrayvwjurfsqfrivayopgrxewwruvemzy",
"xtnipeqhxvafqaggqoanvwkmthtfirwhmjrbphlmeluvoa",
"gqdvlchavotcykafyjzbbgmnlajiqlnwctrnvznspiwquxxsiwuldizqkkaawpyyisnftdzklwagv"};

            ConsoleTester consoleTester = new ConsoleTester(testData);

            Anagram anagram = new Anagram(consoleTester);

            anagram.Solve();

            Assert.AreEqual("10", consoleTester._outputBuffer[0], string.Format("Test02 is wrong, subtest no. {0}",1));
            Assert.AreEqual("13", consoleTester._outputBuffer[1], string.Format("Test02 is wrong, subtest no. {0}",2));
            Assert.AreEqual("5", consoleTester._outputBuffer[2], string.Format("Test02 is wrong, subtest no. {0}",3));
            Assert.AreEqual("26", consoleTester._outputBuffer[3], string.Format("Test02 is wrong, subtest no. {0}",4));
            Assert.AreEqual("15", consoleTester._outputBuffer[4], string.Format("Test02 is wrong, subtest no. {0}",5));
            Assert.AreEqual("-1", consoleTester._outputBuffer[5], string.Format("Test02 is wrong, subtest no. {0}",6));
            Assert.AreEqual("3", consoleTester._outputBuffer[6], string.Format("Test02 is wrong, subtest no. {0}",7));
            Assert.AreEqual("13", consoleTester._outputBuffer[7], string.Format("Test02 is wrong, subtest no. {0}",8));
            Assert.AreEqual("13", consoleTester._outputBuffer[8], string.Format("Test02 is wrong, subtest no. {0}",9));
            Assert.AreEqual("-1", consoleTester._outputBuffer[9], string.Format("Test02 is wrong, subtest no. {0}", 10));
        }
    }
}
