using System.Linq;

namespace HackerRank.Algorithms.Strings
{
    public class TwoStrings
    {
        private IDisplayHandler _console;
        public TwoStrings(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string s1 = _console.ReadLine();
                string s2 = _console.ReadLine();

                bool isfound = false;
                foreach (char c in s1.Distinct())
                {
                    if (s2.Contains(c))
                    {
                        isfound = true;
                        break;
                    }
                }

                if (isfound)
                {
                    _console.WriteLine("YES");
                }
                else
                {
                    _console.WriteLine("NO");
                }
            }
        }
    }
}
