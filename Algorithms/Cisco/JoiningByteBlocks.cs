using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Cisco
{
    public class JoiningByteBlocks
    {
        private IDisplayHandler _console;
        public JoiningByteBlocks(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int N = int.Parse(_console.ReadLine());
            while (N > 0)
            {
                List<string> frames = new List<string>();
                for (int i = 0; i < N; i++)
                {
                    frames.Add(_console.ReadLine());
                }

                List<KeyValuePair<int, int>> pairs = new List<KeyValuePair<int, int>>();
                for (int i = 0; i < N; i++)
                {
                    if (string.IsNullOrEmpty(frames[i])) continue;

                    for (int j = i; j < N; j++)
                    {
                        if (j != i && !string.IsNullOrEmpty(frames[j]))
                        {
                            if (IsPalindrome(string.Concat(frames[i], frames[j])))
                            {
                                pairs.Add(new KeyValuePair<int, int>(i, j));
                            }
                        }
                    }
                }

                pairs.RemoveAll(n => pairs.Any(m => m.Key == n.Value));

                int lastkey = -1;
                int pairsCount = 0;
                foreach (KeyValuePair<int, int> p in pairs)
                {
                    if (p.Key > lastkey)
                    {
                        pairsCount++;
                        lastkey = p.Key;
                    }
                }

                int framesCount = N - pairsCount;
                _console.WriteLine(framesCount.ToString());

                string nextTestLength = _console.ReadLine();
                N = string.IsNullOrEmpty(nextTestLength) ? 0 : int.Parse(nextTestLength);
            }

        }

        public bool IsPalindrome(string word)
        {
            int n = word.Length;
            for (int i = 0; i < (n / 2) + 1; i++)
            {
                if (word[i] != word[n - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
