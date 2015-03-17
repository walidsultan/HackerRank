using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class Pangram
    {
        private IDisplayHandler _console;
        public Pangram(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            string s = _console.ReadLine().ToLower();
            int[] a = new int[26];
            int offset = 97;

            int numberOfCharacters = 0;
            foreach (char c in s.ToCharArray())
            {
                int index=(int)c-offset;
                if (index>0 && a[index] == 0)
                {
                    a[index]++;
                    numberOfCharacters++;
                }

                if (numberOfCharacters == 25)
                {
                    break;
                }
            }

            if (numberOfCharacters == 25)
            {
                _console.WriteLine("pangram");
            }
            else
            {
                _console.WriteLine("not pangram");
            }
        }
    }
}
