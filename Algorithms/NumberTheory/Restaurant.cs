using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.NumberTheory
{
    public class Restaurant
    {
        private IDisplayHandler _console;

        public Restaurant(IDisplayHandler console)
        {
            _console = console;
        }
        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string[] inParams = _console.ReadLine().Split(' ');
                int l = int.Parse(inParams[0]);
                int b = int.Parse(inParams[1]);

                int largestSide = Math.Min(l, b);
                int totalArea = l * b;

                for (int i = largestSide; i > 0; i--)
                {
                    int s = i * i;
                    if (totalArea % s == 0 && l % i == 0 && b % i == 0)
                    {
                        int numberOfSquares = totalArea / (i * i);
                        _console.WriteLine(numberOfSquares.ToString());
                        break;
                    }
                }
            }
        }
    }
}
