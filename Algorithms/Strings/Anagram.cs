using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class Anagram
    {
        private IDisplayHandler _console;

        public Anagram(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string concatenatedString = _console.ReadLine();
                if (concatenatedString.Length % 2 != 0)
                {
                    _console.WriteLine("-1");
                }
                else
                {
                    char[] firstString = concatenatedString.Substring(0, concatenatedString.Length / 2).ToArray();
                    char[] secondString = concatenatedString.Substring(concatenatedString.Length / 2).ToArray();
                    int[] counter = new int[26];
                    for (int i = 0; i < firstString.Length; i++)
                    {
                        counter[(int)firstString[i] - 97]++;
                        counter[(int)secondString[i] - 97]--;
                    }
                    int positiveCount = 0;
                    counter.ToList().ForEach(a =>
                    {
                        if (a > 0) { 
                            positiveCount += a; }
                    });
                    _console.WriteLine(positiveCount.ToString());
                }
            }
        }
    }
}
