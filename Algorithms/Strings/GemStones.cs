using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class GemStones
    {
        private IDisplayHandler _console;
        public GemStones(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int N = int.Parse(_console.ReadLine());
            int[] a = new int[26];
            int offset = 97;
            for (int n = 0; n < N; n++)
            {
                string s = _console.ReadLine();
                foreach (char c in s.ToCharArray().Distinct())
                {
                    int index = (int)c - offset;
                    a[index]++;
                }
            }

            int gemStones = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == N)
                {
                    gemStones++;
                }
            }

            _console.WriteLine(gemStones.ToString());
        }
    }
}
