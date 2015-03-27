using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms._101Hack
{
    public class DevuAndMinimizingRunsOfAString
    {
        private IDisplayHandler _console;

        public DevuAndMinimizingRunsOfAString(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string s = Console.ReadLine();
                char pc = '\0';
                char[] sAr = s.ToCharArray();
                int lowestRuns = GetRuns(s);
                for (int i = 0; i < sAr.Length - 1; i++)
                {
                    if ((sAr[i] != sAr[i + 1]) && (i == 0 || sAr[i] != sAr[i - 1]))
                    {
                        int d = s.IndexOf(sAr[i], 0, i) < 0 ? s.IndexOf(sAr[i], i + 1) : s.IndexOf(sAr[i], 0, i);
                        if (d > 0)
                        {
                            char[] modifiedString = s.ToCharArray();
                            modifiedString[d - 1] = s[i];
                            modifiedString[i] = s[d - 1];
                            int runs = GetRuns(new string(modifiedString));
                            if (runs < lowestRuns)
                            {
                                lowestRuns = runs;
                            }
                        }
                    }
                }

                Console.WriteLine(lowestRuns);
            }
        }

        public int GetRuns(string s)
        {
            char pc = '\0';
            int runs = 0;
            foreach (char c in s.ToCharArray())
            {
                if (c != pc)
                {
                    runs++;
                    pc = c;
                }
            }
            return runs;
        }
    }
}
