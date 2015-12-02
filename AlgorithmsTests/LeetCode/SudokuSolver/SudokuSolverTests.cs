using HackerRank.Algorithms;
using HackerRank.Algorithms.GameTheory;
using HackerRank.Algorithms.LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.AlgorithmsTests.LeetCode
{
    [TestClass]
    public class SudokuSolverTests
    {
        [TestMethod]
        public void SudokuSolverTests_Test01()
        {
            String testDataString = "..9748...,7........,.2.1.9...,..7...24.,.64.1.59.,.98...3..,...8.3.2.,........6,...2759..";
            char[,] testData = convertStringToDoubleArray(testDataString);


            SudokuSolver sudokuSolver = new SudokuSolver();

            sudokuSolver.SolveSudoku(testData);
            
            String answerString="519748632,783652419,426139875,357986241,264317598,198524367,975863124,832491756,641275983";
            char[,] answerData = convertStringToDoubleArray(answerString);

            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    Assert.AreEqual(testData[i, k], answerData[i, k], "Test01 is wrong");
                }
            }
        }

         [TestMethod]
        public void SudokuSolverTests_Test02()
        {
            String testDataString ="6..72...9,....4..3.,3......67,.......83,...8.7...,57.......,95......1,.2..5....,4...31..2";
            char[,] testData = convertStringToDoubleArray(testDataString);


            SudokuSolver sudokuSolver = new SudokuSolver();

            sudokuSolver.SolveSudoku(testData);
            
            String answerString="645723819,817649235,392185467,164592783,239867154,578314926,953278641,721456398,486931572";
            char[,] answerData = convertStringToDoubleArray(answerString);

            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    Assert.AreEqual(testData[i, k], answerData[i, k], "Test02 is wrong");
                }
            }
        }
 

        private static char[,] convertStringToDoubleArray(String testDataString)
        {
            String[] rows = testDataString.Split(',');
            char[,] testData = new char[9, 9];
            int i = 0;
            foreach (String row in rows)
            {
                int j = 0;
                foreach (char c in row.ToCharArray())
                {
                    testData[i, j] = c;
                    j++;
                }
                i++;
            }
            return testData;
        }

    }
}
