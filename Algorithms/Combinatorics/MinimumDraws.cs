using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Combinatorics
{
    public class MinimumDraws
    {
        private IOutputWriter _writer;
        private IInputReader _reader;

        public MinimumDraws(IOutputWriter writer, IInputReader reader)
        {
            _writer = writer;
            _reader = reader;
        }

        public void Init()
        {
            int T = int.Parse(_reader.ReadLine());

            for (int test = 0; test < T; test++)
            { 
                int totalNumberOfPairs= int.Parse(_reader.ReadLine());
                _writer.WriteLine((totalNumberOfPairs + 1).ToString());
            }
        }
    }
}
