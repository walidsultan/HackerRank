using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank.Algorithms.ArraysAndSorting
{
    public class InsertionSort
    {
        static void Solve(int[] ar)
        {
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < ar[i - 1])
                {
                    int v = ar[i];
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (v < ar[j])
                        {
                            ar[j + 1] = ar[j];
                            ar[j] = v;
                        }
                    }
                }
                printArray(ar);
            }
            Console.ReadKey();
        }

        static void printArray(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.Write("\n");
        }

    }
}