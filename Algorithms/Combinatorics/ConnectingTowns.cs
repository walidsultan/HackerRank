using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Combinatorics
{
    class ConnectingTowns
    {
           private IOutputWriter _writer;
        private IInputReader _reader;

        public ConnectingTowns(IOutputWriter writer, IInputReader reader)
        {
            _writer = writer;
            _reader = reader;
        }

        public void Init()
        {
            int T = int.Parse(_reader.ReadLine());

            for (int test = 0; test < T; test++)
            { 
                int numberOfTowns= int.Parse(_reader.ReadLine());
                int[] paths= _reader.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

                int totalNumberOfPaths = 1;
                foreach (int pathsCount in paths)
                {
                    totalNumberOfPaths *=pathsCount;
                    totalNumberOfPaths = totalNumberOfPaths % 1234567;
                }
                _writer.WriteLine(totalNumberOfPaths.ToString());
            }
        }
    }
}
