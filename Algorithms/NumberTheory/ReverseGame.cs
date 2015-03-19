using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.NumberTheory
{
   public class ReverseGame
    {
          private IDisplayHandler _console;

          public ReverseGame(IDisplayHandler console)
        {
            _console = console;
        }

          public void Solve()
          {
              int T = int.Parse(_console.ReadLine());
              for (int t = 0; t < T; t++)
              {
                  int[] test = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                  int n = test[0] - 1;
                  int k = test[1];
                  int index = 0;
                  if (k >=  (float) n / 2)
                  {
                      index = (n - k) * 2;
                  }
                  else
                  {
                      index = 2 * k + 1;
                  }
                  _console.WriteLine(index.ToString());
              }
          }
    }
}
