using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GameTheory
{
    public class PermutationGame
    {
        private IDisplayHandler _console;

        public PermutationGame(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int n = int.Parse(_console.ReadLine());
                int[] ar = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

                int numberNeededToBeRemoved = 0;
                int max = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > max)
                    {
                        max = ar[i];
                    }
                    else
                    {
                        numberNeededToBeRemoved++;
                    }
                }

                if (numberNeededToBeRemoved % 2 == 0)
                {
                    _console.WriteLine("Bob");
                }
                else
                {
                    _console.WriteLine("Alice");
                }
            }
        }
    }
}
