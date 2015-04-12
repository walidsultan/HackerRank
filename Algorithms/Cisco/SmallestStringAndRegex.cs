using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Cisco
{
    public class SmallestStringAndRegex
    {
        private IDisplayHandler _console;
        public SmallestStringAndRegex(IDisplayHandler console)
        {
            _console = console;
        }
        //public void Solve1()
        //{
        //    int T = int.Parse(_console.ReadLine());

        //    for (int test = 0; test < T; test++)
        //    {
        //        int len = int.Parse(_console.ReadLine());
        //        string regex = _console.ReadLine();

        //        regex = simplifyRegex(regex);

        //        List<int> starIndexes = AllIndexesOf(regex, "*");
        //        List<int> openBracketIndexes = AllIndexesOf(regex, "(");
        //        List<int> closedBracketIndexes = AllIndexesOf(regex, ")");
        //        List<int> orIndexes = AllIndexesOf(regex, "|");

        //        List<int> multipliers = new List<int>();
        //        foreach (int starIndex in starIndexes)
        //        {
        //            if (regex[starIndex - 1] == ')')
        //            {
        //                //Concatenation
        //                int openBracketIndex = openBracketIndexes.Where(n => n < starIndex).OrderByDescending(n => n).First();
        //                int concatLength = starIndex - openBracketIndex - 2;

        //                multipliers.Add(concatLength);
        //            }
        //            else
        //            {
        //                multipliers.Add(1);
        //            }
        //        }

        //        int stringCount = 0;
        //        for (int i = 0; i < regex.Length - 1; i++)
        //        {
        //            char nextLetter = regex[i + 1];
        //            char currentLetter = regex[i];
        //            if (currentLetter != '*' && currentLetter != '(' && currentLetter != ')' && currentLetter != '|')
        //            {
        //                stringCount++;
        //            }
        //        }

        //        int minLength = -1;

        //        int multiplierCount = 0;
        //        foreach (int multi in multipliers)
        //        {
        //            multiplierCount += multi;
        //        }
        //        stringCount -= multiplierCount;

        //        if (stringCount >= len && stringCount <= 500)
        //        {
        //            minLength = stringCount;
        //        }
        //        else
        //        {
        //            int remainder = len - stringCount;
        //            if (multipliers.Count > 0)
        //            {
        //                int multiplier = multipliers.OrderBy(m => remainder % m).First();
        //                minLength = len + remainder % multiplier;
        //                if (minLength > 500) minLength = -1;
        //            }
        //        }
        //        _console.WriteLine(minLength.ToString());
        //    }
        //}

        public void Solve()
        {
            int T = int.Parse(_console.ReadLine());

            for (int test = 0; test < T; test++)
            {
                int len = int.Parse(_console.ReadLine());
                string regex = _console.ReadLine();

                List<Unit> units = new List<Unit>();
                regex = simplifyRegex(regex, units);

                int rootCount = regex.Length;

                foreach (Unit unit in units.Where(u => u.Lengths.Count == 1 && !u.IsRepeatable))
                {
                    rootCount += unit.Lengths[0];
                }

                var variableUnits = units.Where(u => u.Lengths.Count > 1 || u.IsRepeatable).OrderBy(u => u.IsRepeatable).ToList();
                int possibleSolutions = 1;
                int[] indexer = new int[variableUnits.Count()];
                for (int i = 0; i < indexer.Length; i++)
                {
                    possibleSolutions *= variableUnits[i].Lengths.Count;
                    // indexer[i] = variableUnits[i].Lengths.Count;
                }

                int minLength = -1;
                int index = 0;
                for (int i = 0; i < possibleSolutions; i++)
                {
                    int possibleLength = rootCount;
                    for (int j = 0; j < indexer.Length; j++)
                    {
                        Unit unit = variableUnits[j];
                        if (!unit.IsRepeatable)
                        {
                            possibleLength += unit.Lengths[indexer[j]];
                        }
                        else
                        {
                            if (possibleLength < len)
                            {
                                int remainder = len - possibleLength;
                                possibleLength = len + remainder % unit.Lengths[indexer[j]];
                            }
                        }
                    }
                    if (possibleLength >= len && possibleLength <= 500 &&  (possibleLength<minLength||minLength==-1))
                    {
                        minLength = possibleLength;
                    }
                    if (index < indexer.Length)
                    {
                        indexer[index]++;
                        if (indexer[index] == variableUnits[index].Lengths.Count)
                        {
                            indexer[index] = 0;
                            index++;
                        }
                    }
                }
                _console.WriteLine(minLength.ToString());
            }
        }

        public static string simplifyRegex(string regex, List<Unit> units)
        {
            int firstClosedBracketIndex = regex.IndexOf(')');
            int starIndex = regex.IndexOf('*');
            if (firstClosedBracketIndex > 0)
            {
                int openBracketIndex = -1;
                for (int i = firstClosedBracketIndex; i >= 0; i--)
                {
                    if (regex[i] == '(')
                    {
                        openBracketIndex = i;
                        break;
                    }
                }
                int concatLength = firstClosedBracketIndex - openBracketIndex - 1;

                int nextCharIndex = firstClosedBracketIndex + 1;
                bool isRepeatable = nextCharIndex < regex.Length && regex[nextCharIndex] == '*';

                string[] terms = regex.Substring(openBracketIndex + 1, concatLength).Split('|');

                List<int> lengths = new List<int>();
                foreach (string term in terms)
                {
                    lengths.Add(term.Length);
                }
                lengths = lengths.Distinct().ToList();

                units.Add(new Unit() { Lengths = lengths, IsRepeatable = isRepeatable });

                if (terms.Length > 0)
                {
                    int startIndex = openBracketIndex;
                    int length = concatLength + 2 + (isRepeatable ? 1 : 0);
                    regex = regex.Remove(startIndex, length);
                    if (!isRepeatable)
                    {
                        string simplifiedString = new String('a', terms[0].Length);
                        regex = regex.Insert(startIndex, simplifiedString);
                    }
                }
                return simplifyRegex(regex, units);
            }
            else if (starIndex > 0)
            {
                //Star with no brackets
                List<int> lengths = new List<int>();
                lengths.Add(1);
                units.Add(new Unit()
                {
                    IsRepeatable = true,
                    Lengths = lengths
                });
                regex = regex.Remove(starIndex - 1, 2);
               
                return simplifyRegex(regex, units);
            }

            return regex;
        }


        //public static string simplifyRegex2(string regex)
        //{
        //    int firstClosedBracketIndex = regex.IndexOf(')');
        //    if (firstClosedBracketIndex > 0)
        //    {
        //        int openBracketIndex = -1;
        //        for (int i = firstClosedBracketIndex; i >= 0; i--)
        //        {
        //            if (regex[i] == '(')
        //            {
        //                openBracketIndex = i;
        //                break;
        //            }
        //        }
        //        int concatLength = firstClosedBracketIndex - openBracketIndex - 1;
        //        int orIndexCount = regex.Substring(openBracketIndex, concatLength).Count(s => s == '|');

        //        int nextCharIndex = firstClosedBracketIndex + 1;
        //        bool removeBrackets = !(nextCharIndex < regex.Length && regex[nextCharIndex] == '*');

        //        if (removeBrackets || orIndexCount > 0)
        //        {
        //            int bracketLength = (concatLength - orIndexCount) / (orIndexCount + 1);
        //            int startIndex = removeBrackets ? openBracketIndex : openBracketIndex + 1;
        //            int length = removeBrackets ? concatLength + 2 : concatLength;
        //            regex = regex.Remove(startIndex, length);
        //            string simplifiedString = new String('a', bracketLength);
        //            regex = regex.Insert(startIndex, simplifiedString);

        //            return simplifyRegex(regex);
        //        }
        //    }

        //    return regex;
        //}

        public static List<int> AllIndexesOf(string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }

    public class Unit
    {
        public List<int> Lengths { get; set; }
        public bool IsRepeatable { get; set; }
    }
}
