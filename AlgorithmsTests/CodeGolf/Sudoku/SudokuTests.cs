using HackerRank.Algorithms;
using HackerRank.Algorithms.CodeGolf;
using HackerRank.Algorithms.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.AlgorithmsTests.Cryptography
{
    [TestClass]
    public class SudokuTests
    {
        [TestMethod]
        public void Sudoku_Test01()
        {
            string[] stringSeparators = new string[] { "\r\n", "\r", "\n" };
            string[] testData = File.ReadAllText("CodeGolf\\Sudoku\\input00.txt").Split(stringSeparators, StringSplitOptions.None);

            ConsoleTester consoleTester = new ConsoleTester(testData);

            Sudoku sudoku = new Sudoku(consoleTester);

            PuzzleStub(sudoku, consoleTester);

            string[] outputData = File.ReadAllText("CodeGolf\\Sudoku\\output00.txt").Split(stringSeparators, StringSplitOptions.None);

            for (int i = 0; i < outputData.Length; i++)
            {
                Assert.AreEqual(consoleTester._outputBuffer[i], outputData[i], string.Format("Test10 is wrong for test {0}", i));
            }
        }

        private void PuzzleStub(Sudoku sudoku,  ConsoleTester consoleTester)
        {
            int n = int.Parse(consoleTester.ReadLine());
            int[,] board = new int[9, 9];
            String line;
            String[] temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    line = consoleTester.ReadLine();
                    temp = line.Split(' ');
                    for (int k = 0; k < 9; k++)
                    {
                        board[j, k] = int.Parse(temp[k]);
                    }
                }
                sudoku.Solve(board);
            }
        }
    }
}
