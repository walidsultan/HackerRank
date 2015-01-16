using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Combinatorics
{
    public class HandShake
    {
        private IOutputWriter _writer;
        private IInputReader _reader;

        public HandShake(IOutputWriter writer, IInputReader reader)
        {
            _writer = writer;
            _reader = reader;
        }

        public void Solve()
        {
            int T = int.Parse(_reader.ReadLine());

            for (int test = 0; test < T; test++)
            { 
                int numberOfPersons= int.Parse(_reader.ReadLine());

                int numberOfHandShakes = 0;
                for (int i = numberOfPersons - 1; i > 0;i-- )
                {
                    numberOfHandShakes += i;
                }
                _writer.WriteLine(numberOfHandShakes.ToString());
            }
        }
    }
}
