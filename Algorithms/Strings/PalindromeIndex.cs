using System;
using System.Linq;

namespace HackerRank.Algorithms.Strings
{
    public class PalindromeIndex
    {
        private IDisplayHandler _console;
        public PalindromeIndex(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            int offset = 97;
            for (int t = 0; t < T; t++)
            {
                string text = _console.ReadLine();
                int[] a = new int[25];
                foreach (char c in text.ToCharArray())
                {
                    int index = (int)c - offset;
                    a[index]++;
                }
                if (IsPalindrome(text))
                {
                    _console.WriteLine("-1");
                    continue;
                }

                for (int i = 0; i < 25; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        char c = (char)(i + offset);
                        int startIndex = 0;
                        bool isPalindromeFound = false;
                        for (int j = 0; j < a[i]; j++)
                        {
                            startIndex = text.IndexOf(c, startIndex);
                            string word = text.Remove(startIndex,1);
                            if (IsPalindrome(word))
                            {
                                _console.WriteLine(startIndex.ToString());
                                isPalindromeFound = true;
                                break;
                            }
                            startIndex++;
                        }
                        if (isPalindromeFound)
                        {
                            break;
                        }
                    }
                }
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
