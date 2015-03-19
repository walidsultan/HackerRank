using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Cryptography
{
    public class KeywordTranspositionCipher
    {
        private IDisplayHandler _console;

        public KeywordTranspositionCipher(IDisplayHandler console)
        {
            _console = console;
        }

        public void Solve()
        {
            char[]ss= Enumerable.Range('a', 26).Select(s=>(char)s).ToArray();

            int T = int.Parse(_console.ReadLine());
            int offset = 97;
            int alphabetLength = 26;
            for (int t = 0; t < T; t++)
            {
                List<char[]> table = new List<char[]>();
                char[] keyword = _console.ReadLine().ToLower().Distinct().ToArray();
                table.Add(keyword);

                for (int i = 0; i < alphabetLength; i++)
                {
                    char[] word = new char[keyword.Length];
                    for (int j = 0; j < keyword.Length; j++)
                    {
                        if ((i + j) < alphabetLength)
                        {
                            char c = (char)(offset + i + j);
                            if (Array.IndexOf(keyword, c) < 0)
                            {
                                word[j] = c;
                            }
                            else
                            {
                                j--;
                                i++;
                                continue;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    i += (word.Length-1);
                    table.Add(word);
                }

                char[] sortedKeyword = keyword.OrderBy(s => s).ToArray();
                for (int i = 0; i < keyword.Length; i++)
                {
                    if (sortedKeyword[i] != keyword[i])
                    {
                        int newIndex = Array.IndexOf(keyword, sortedKeyword[i]);
                        foreach (char[] word in table)
                        {
                            char temp = word[newIndex];
                            word[newIndex] = word[i];
                            word[i] = temp;
                        }
                    }
                }

                char[] substitutionArray = new char[alphabetLength];
                int si = 0;
                for (int i = 0; i < keyword.Length; i++)
                {
                    for (int j = 0; j < table.Count; j++)
                    {
                        if (table[j][i] != '\0')
                        {
                            substitutionArray[si] = table[j][i];
                            si++;
                        }
                    }
                }

                string cypherText = _console.ReadLine();
                string originalText = string.Empty;
                foreach (char c in cypherText.ToLower().ToCharArray())
                {
                    if (c != ' ')
                    {
                         int index  = Array.IndexOf(substitutionArray,c);
                        originalText+=(char)( index+offset);
                    }
                    else
                    {
                        originalText += " ";
                    }
                }

                _console.WriteLine(originalText.ToUpper());
            }
        }
    }
}
