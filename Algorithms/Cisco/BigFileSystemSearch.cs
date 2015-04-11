using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Cisco
{
    public class BigFileSystemSearch
    {
        private IDisplayHandler _console;
        public BigFileSystemSearch(IDisplayHandler console)
        {
            _console = console;
        }
        public void Solve()
        {
            int N = int.Parse(_console.ReadLine());

            List<List<int>> files = new List<List<int>>();
            for (int file = 0; file < N; file++)
            {
                List<int> fileArray = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).Skip(1).ToList();
                files.Add(fileArray);
            }
            int Q = int.Parse(_console.ReadLine());
            List<int[]> queries = new List<int[]>();
            for (int q = 0; q < Q; q++)
            {
                int[] query = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                queries.Add(query);
            }

            foreach (int[] query in queries)
            {
                int T = query[0];
                int K = query[1];
                int[] arr = query.Skip(2).ToArray();
                int filesCount = 0;

                switch (T)
                {
                    case 1:
                        foreach (List<int> file in files)
                        {
                            bool found = true;
                            int[] fileCopyArr = new int[file.Count];
                            file.CopyTo(fileCopyArr);
                            List<int> fileCopy = fileCopyArr.ToList();
                            foreach (int a in arr)
                            {
                                int aIndex = fileCopy.IndexOf(a);
                                if (aIndex == -1)
                                {
                                    found = false;
                                    break;
                                }
                                else
                                {
                                    file[aIndex] = -1;
                                }
                            }
                            if (found)
                            {
                                filesCount++;
                            }
                        }
                        break;
                    case 2:
                        foreach (List<int> file in files)
                        {
                            bool found = file.Any(f => arr.Contains(f));
                            if (found)
                            {
                                filesCount++;
                            }
                        }
                        break;
                    case 3:
                        foreach (List<int> file in files)
                        {
                            bool found = true;
                            int[] fileCopyArr = new int[file.Count];
                            file.CopyTo(fileCopyArr);
                            List<int> fileCopy = fileCopyArr.ToList();
                            foreach (int a in arr)
                            {
                                int aIndex = fileCopy.IndexOf(a);
                                if (aIndex == -1)
                                {
                                    found = false;
                                    break;
                                }
                                else
                                {
                                    file[aIndex] = -1;
                                }
                            }
                            if (found)
                            {
                                filesCount++;
                            }
                        }
                        break;
                }
                _console.WriteLine(filesCount.ToString());
            }
        }
    }
}
