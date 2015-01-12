using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class KnapSack
    {
        public KnapSack()
        {
            //  int T = int.Parse(Console.ReadLine());
            int T = 1;
            for (int t = 0; t < T; t++)
            {
                //string[] inParams = Console.ReadLine().Split(' ');
                //int k = int.Parse(inParams[1]);
                //int[] ar = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                int k = 6;
                int[] ar = {5 };
                List<int> results = new List<int>();

                int s=GetSmallestRemainder(ar, k);

                Console.WriteLine(k - s);
            }

            Console.ReadKey();
        }

        int GetSmallestRemainder(int[] ar, int v)
        {
            int smallestRemainder = v;
            for (int i = 0; i < ar.Length; i++)
            {
                int r = v % ar[i];
                if (r == 0)
                {
                    return 0;
                }
                else if (r < v)
                {
                    int s= GetSmallestRemainder(ar, r);
                    if (s == 0) return s;
                    if (s < smallestRemainder) smallestRemainder = s;
                }
            }
            return smallestRemainder;
        }
    }
}
