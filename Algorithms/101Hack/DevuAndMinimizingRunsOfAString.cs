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
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string s = _console.ReadLine();
                s = MinimizeString(s);
                char[] sAr = s.ToCharArray();
                int lowestRuns = GetRuns(s);
                for (int i = 0; i < sAr.Length; i++)
                {
                    if ((i == (sAr.Length - 1) || sAr[i] != sAr[i + 1]) && (i == 0 || sAr[i] != sAr[i - 1]))
                    {
                        List<int> foundIndexes = new List<int>();
                        if (sAr[i] == 'B')
                        {
                            for (int d = s.IndexOf('R'); d > -1; d = s.IndexOf('B', d + 1))
                            {
                                foundIndexes.Add(d);
                            }
                        }
                        else
                        {
                            for (int d = s.IndexOf('B'); d > -1; d = s.IndexOf('R', d + 1))
                            {
                                foundIndexes.Add(d);
                            }
                        }
                        foreach (int d in foundIndexes)
                        {
                            string modifiedString = s.Remove(i, 1); ;
                            modifiedString = modifiedString.Insert(d, s[i].ToString());
                            int runs = GetRuns(modifiedString);
                            if (runs < lowestRuns)
                            {
                                lowestRuns = runs;
                            }
                        }
                    }
                }

                _console.WriteLine(lowestRuns.ToString());
            }
        }

        private string MinimizeString(string s)
        {
            string minimizedString = s[0].ToString();
            bool firstDublicate = true;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1] || firstDublicate)
                {
                    minimizedString += s[i];
                    firstDublicate=!firstDublicate;
                }
            }
            return minimizedString;
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
