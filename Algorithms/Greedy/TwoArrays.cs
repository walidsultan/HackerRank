using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Greedy
{
    public class TwoArrays
    {
        private IDisplayHandler _console;
        public TwoArrays(IDisplayHandler console)
        {
            _console = console;
        }
        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int[] arr = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                int K = arr[1];

                int[] arrA = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).OrderByDescending(s => s).ToArray();
                int[] arrB = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).OrderBy(s => s).ToArray();

                bool isPossible = true;
                for (int i = 0; i < arrA.Length; i++)
                {
                    int d = (arrA[i] + arrB[i]) - K;
                    if (d < 0)
                    {
                        isPossible = false;
                        break;
                    }
                }

                if (isPossible)
                {
                    _console.WriteLine("YES");
                }
                else
                {
                    _console.WriteLine("NO");
                }
            }
        }
    }
}
