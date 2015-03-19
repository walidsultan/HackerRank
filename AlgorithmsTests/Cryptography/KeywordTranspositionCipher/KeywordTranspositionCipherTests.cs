using HackerRank.Algorithms;
using HackerRank.Algorithms.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.AlgorithmsTests.Cryptography
{
    [TestClass]
    public class KeywordTranspositionCipherTests
    {
        [TestMethod]
        public void KeywordTranspositionCipher_Test01()
        {
            string[] testData = { "2", "SPORT", "LDXTW KXDTL NBSFX BFOII LNBHG ODDWN BWK", "SECRET", "JHQSU XFXBQ" };
            
            ConsoleTester consoleTester = new ConsoleTester(testData);

            KeywordTranspositionCipher keywordTranspositionCipher = new KeywordTranspositionCipher(consoleTester);

            keywordTranspositionCipher.Solve();

            Assert.AreEqual("ILOVE SOLVI NGPRO GRAMM INGCH ALLEN GES", consoleTester._outputBuffer[0], "Test01 is wrong");
            Assert.AreEqual("CRYPT OLOGY", consoleTester._outputBuffer[1], "Test01 is wrong");
        }
    }
}
