using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Greedy
{
    public class PriyankaAndToys
    {
        private IDisplayHandler _console;
        public PriyankaAndToys(IDisplayHandler console)
        {
            _console = console;
        }
        public void Solve()
        {
            int N = int.Parse(_console.ReadLine());
            int[] arr = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).OrderBy(s=>s).ToArray();

            int w = arr[0];
            int p = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] - w > 4)
                {
                    p++;
                    w = arr[i];
                }
            }
            _console.WriteLine(p.ToString());
        }
    }
}
