using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms._101Hack
{
    public class MagicalGirlDevuAndSpirits
    {
        private IDisplayHandler _console;

        public MagicalGirlDevuAndSpirits(IDisplayHandler console)
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
                bool usedSpecialPower = false;
                Int64 girlHealth = 0;
                bool survived = true;
                for (int i = 0; i < n; i++)
                {
                    int p = ar[i];

                    if ((girlHealth + p) < 0)
                    {
                        if (!usedSpecialPower)
                        {
                            int bestSpirit = ar.ToList().Take(i).OrderBy(s => s ).FirstOrDefault();
                            if (bestSpirit < p)
                            {
                                girlHealth += ((-2 * bestSpirit) + p);
                            }
                            else
                            {
                                girlHealth += -p;
                            }
                            usedSpecialPower = true;
                        }
                        else
                        {
                            _console.WriteLine((i + 1).ToString());
                            survived = false;
                            break;
                        }
                    }
                    else
                    {
                        girlHealth += p;
                    }
                }
                if (survived)
                {
                    _console.WriteLine("She did it!");
                }
            }
        }
    }
}
