using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Greedy
{
  public  class MarkAndToys
    {
      private IDisplayHandler _console;
      public MarkAndToys(IDisplayHandler console)
        {
            _console = console;
        }
      public void Solve()
      {
          int[] T = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
          int N = T[0];
          int K = T[1];

          int[] arr = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).OrderBy(s=>s).ToArray();

          int toysCost = 0;
          for (int i = 0; i<arr.Length; i++)
          {
              toysCost += arr[i];
              if (toysCost > K)
              {
                  _console.WriteLine(i.ToString());
                  break;
              }
          }
      }
    }
}
