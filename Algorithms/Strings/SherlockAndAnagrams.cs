using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class SherlockAndAnagrams
    {
        private IDisplayHandler _console;
        public SherlockAndAnagrams(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string s = _console.ReadLine();
                int anagrams = 0;
                for (int x = 1; x < s.Length ; x++)
                {
                    for (int i = 0; i < (s.Length - x+1); i++)
                    {
                        string si = s.Substring(i, x);
                        for (int j = 0; j < (s.Length - x+1); j++)
                        {
                            if (i != j)
                            {
                                string sj = s.Substring(j, x);
                                if (IsAnagram(si,sj))
                                {
                                    anagrams++;
                                }
                            }
                        }
                    }
                }
                _console.WriteLine((anagrams/2).ToString());
            }
        }

        public bool IsAnagram(string s1, string s2)
        {
            int[] counter = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                counter[(int)s1[i] - 97]++;
                counter[(int)s2[i] - 97]--;
            }
            int positiveCount = 0;
            counter.ToList().ForEach(a =>
            {
                if (a > 0)
                {
                    positiveCount += a;
                }
            });
            return positiveCount==0;
        }
    }
}
