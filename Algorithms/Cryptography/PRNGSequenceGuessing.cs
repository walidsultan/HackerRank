using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Cryptography
{
    public class PRNGSequenceGuessing
    {
        private IDisplayHandler _console;

        public PRNGSequenceGuessing(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                string[] seedRange = _console.ReadLine().Split(' ');

                int[] expectedOutput = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    expectedOutput[i] = int.Parse(_console.ReadLine());
                }

                int startSeed = int.Parse(seedRange[0]);
                int stopSeed = int.Parse(seedRange[1]);

                
                for (int i = 0; i < (stopSeed - startSeed); i++)
                {
                    Random random = new Random(startSeed + i);
                    string output = string.Empty;
                    bool isCorrectSeed = true;
                    for (int j = 0; j < 10; j++)
                    {
                        int actualOutput = random.Next (1000);
                        if (expectedOutput[j] != actualOutput)
                        {
                            isCorrectSeed = false;
                            break;
                        }
                    }
                    //Got the correct seed
                    if (isCorrectSeed)
                    {
                        output = (startSeed + i).ToString();
                        for (int z = 0; z < 10; z++)
                        {
                            output += " " + random.Next(1000).ToString();
                        }

                        if (!string.IsNullOrEmpty(output))
                        {
                            _console.WriteLine(output);
                            break;
                        }
                    }
                }
            }
        }
    }
}
