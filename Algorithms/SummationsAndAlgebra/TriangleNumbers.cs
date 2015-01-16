using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.SummationsAndAlgebra
{
    public class TriangleNumbers
    {
        private IDisplayHandler _console;

        public TriangleNumbers(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                ulong lineNumber = ulong.Parse(_console.ReadLine());

                if ((lineNumber - 1) % 2 == 0)
                {
                    _console.WriteLine("2");
                }
                else
                {
                    // int evenIndex = 0;
                    ulong n = 0;
                    //i==3
                    n = ((lineNumber - 1) * lineNumber) / 2;
                    if (n % 2 == 0)
                    {
                        _console.WriteLine("3");
                        continue;
                    }
                    //i==4
                    n = (n * (lineNumber - 3)) * ((lineNumber - 2) / (3 * lineNumber));
                    if (n % 2 == 0)
                    {
                        _console.WriteLine("4");
                        continue;
                    }
                    _console.WriteLine("0");
                }
            }
        }
    }
}
