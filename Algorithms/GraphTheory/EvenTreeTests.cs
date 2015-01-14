using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GraphTheory
{
    class EvenTreeTests
    {
        public void Test1()
        {
            string[] testData = { "10 9", "2 1", "3 1", "4 3", "5 2", "6 1", "7 2", "8 6", "9 8", "10 8" };

            TestInputReader reader = new TestInputReader(testData);
            TestOutputWriter writer = new TestOutputWriter();

            EvenTree evenTree = new EvenTree(writer, reader);

            evenTree.Init();
            Debug.Assert(writer._buffer[0] == "2");
        }

        public void Test2()
        {
            string[] testData = { "20 19", "2 1", "3 1", "4 3", "5 2", "6 5", "7 1", "8 1", "9 2", "10 7", "11 10", "12 3", "13 7", "14 8", "15 12", "16 6", "17 6", "18 10", "19 1", "20 8" };

            TestInputReader reader = new TestInputReader(testData);
            TestOutputWriter writer = new TestOutputWriter();

            EvenTree evenTree = new EvenTree(writer, reader);

            evenTree.Init();
            Debug.Assert(writer._buffer[0] == "4");
        }

        public void Test3()
        {
            string[] testData = { "50 49", "2 1", "3 1", "4 2", "5 2", "6 4", "7 6", "8 5", "9 1", "10 9", "11 4", "12 6", "13 12", "14 1", "15 5", "16 2", "17 8", "18 7", "19 3", "20 18", "21 3", "22 9", "23 6", "24 18", "25 13", "26 11", "27 18", "28 27", "29 13", "30 25", "31 30", "32 24", "33 12", "34 11", "35 12", "36 3", "37 31", "38 21", "39 27", "40 12", "41 22", "42 14", "43 42", "44 33", "45 1", "46 24", "47 22", "48 30", "49 22", "50 43" };

            TestInputReader reader = new TestInputReader(testData);
            TestOutputWriter writer = new TestOutputWriter();

            EvenTree evenTree = new EvenTree(writer, reader);

            evenTree.Init();
            Debug.Assert(writer._buffer[0] == "12");
        }

         public void Test4()
        {
            string[] testData = { "30 29", "2 1", "3 2", "4 3", "5 2", "6 4", "7 4", "8 1", "9 5", "10 4", "11 4", "12 8", "13 2", "14 2", "15 8", "16 10", "17 1", "18 17", "19 18", "20 4", "21 15", "22 20", "23 2", "24 12", "25 21", "26 17", "27 5", "28 27", "29 4", "30 25" };

            TestInputReader reader = new TestInputReader(testData);
            TestOutputWriter writer = new TestOutputWriter();

            EvenTree evenTree = new EvenTree(writer, reader);

            evenTree.Init();
            Debug.Assert(writer._buffer[0] == "11");
        }

        
    }
}
