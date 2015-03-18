using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.SummationsAndAlgebra
{
    public class SummingTheNSeries
    {
        private IDisplayHandler _console;

        public SummingTheNSeries(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            Int64 dividor = (Int64)Math.Pow(10, 9) + 7;
            for (int t = 0; t < T; t++)
            {
                Int64 n = Int64.Parse(_console.ReadLine());
                n = n % dividor;
                Int64 summation = (n * n) % dividor;
                _console.WriteLine(summation.ToString());
            }
        }
    }
}
