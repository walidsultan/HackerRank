using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Cisco
{
    public class TouchingSegments
    {
        private IDisplayHandler _console;
        public TouchingSegments(IDisplayHandler console)
        {
            _console = console;
        }
        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());

            for (int test = 0; test < T; test++)
            {
                int N = int.Parse(_console.ReadLine());
                List<Line> lines = new List<Line>();
                for (int i = 0; i < N; i++)
                {
                    int[] line = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                    lines.Add(new Line()
                    {
                        a = line[0],
                        b = line[1]
                    });
                }

                //Sort by line length
                lines = lines.OrderBy(line => line.b - line.a).ToList();

                //    int x = 0;
                Line ln = null;
                List<int> groups = new List<int>();
                for (int i = 0; i < N; i++)
                {
                    ln = lines[i];
                    if (ln.used) continue;

                    //   x++;
                    ln.used = true;

                    int lineCount = 1;
                    foreach (Line line in lines)
                    {
                        if (!line.used && ( (line.a <= ln.b && line.b>=ln.a) || (line.b >= ln.a && line.a<=ln.b )))
                        {
                            lineCount++;
                            line.used = true;
                        }
                    }
                    groups.Add(lineCount);
                }
                groups = groups.OrderByDescending(s => s).ToList();
                int totalNumberOfLines = groups[0] +  (groups.Count > 1 ? groups[1] : 0);
                _console.WriteLine(string.Format("Case {0}: {1}", test + 1, totalNumberOfLines));
            }
        }
    }

    public class Line
    {
        public int a { get; set; }
        public int b { get; set; }
        public bool used { get; set; }
    }
}
