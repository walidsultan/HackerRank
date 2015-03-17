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
            for (int t = 0; t < T; t++)
            {
                string text = _console.ReadLine();
                if (IsPalindrome(text))
                {
                    _console.WriteLine("-1");
                }
                else
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        string word = text.Remove(i, 1);
                        if (IsPalindrome(word))
                        {
                            _console.WriteLine(i.ToString());
                            break;
                        }
                    }
                }
            }
        }

        public bool IsPalindrome(string word) {

            if (word.Length % 2 != 0 && word.Substring(0, (word.Length - 1) / 2) == new String(word.Substring((word.Length + 1) / 2).Reverse().ToArray()))
            {
                return true;
            }
            else if (word.Length % 2 == 0 && word.Substring(0, word.Length / 2) == new String(word.Substring(word.Length / 2).Reverse().ToArray())) 
            {
                return true;
            }
            return false;
        }
    }
}
