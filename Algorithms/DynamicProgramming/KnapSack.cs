using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.DynamicProgramming
{
    public class KnapSack
    {
         private IDisplayHandler _console;

         public KnapSack(IDisplayHandler console)
        {
            _console = console;
        }


        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string[] inParams = _console.ReadLine().Split(' ');
                int k = int.Parse(inParams[1]);
                int[] ar = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

                int r = GetSmallestRemainder(ar, k);

                _console.WriteLine((k - r).ToString());
            }
        }

        int GetSmallestRemainder(int[] ar, int v)
        {
            int smallestRemainder = v;
            for (int i = 0; i < ar.Length; i++)
            {
                int r = v % ar[i];
                if (r == 0)
                {
                    return 0;
                }
                else if (r < v)
                {
                    int s= GetSmallestRemainder(ar, r);
                    if (s == 0) return s;
                    if (s < smallestRemainder) smallestRemainder = s;
                }
            }
            return smallestRemainder;
        }
    }
}
