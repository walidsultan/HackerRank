using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class MakeItAnagram
    {
        private IDisplayHandler _console;
        public MakeItAnagram(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            string s1 = _console.ReadLine().ToLower();
            string s2 = _console.ReadLine().ToLower();
            int[] a = new int[26];
            int offset = 97;

            foreach (char c in s1.ToCharArray())
            {
                int index= (int)c -offset;
                a[index]++;
            }

            foreach (char c in s2.ToCharArray())
            {
                int index = (int)c - offset;
                a[index]--;
            }

            int numberOfDeletions=0;
            for (int i = 0; i < a.Length; i++)
            {
                numberOfDeletions += Math.Abs(a[i]);
            }

            _console.WriteLine(numberOfDeletions.ToString());
        }
    }
}
