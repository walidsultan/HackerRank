using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.NumberTheory
{
    public class MatrixTree
    {
        private IDisplayHandler _console;
        public MatrixTree(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int N = int.Parse(_console.ReadLine());
            int[] W = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < N-1; i++)
            {
                //Read edges

            }
        }
    }
}
