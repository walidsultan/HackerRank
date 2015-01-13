using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.GraphTheory
{
    public class AJourneyToTheMoon
    {
        private IOutputWriter _writer;
        private IInputReader _reader;

        public AJourneyToTheMoon(IOutputWriter writer, IInputReader reader)
        {
            _writer = writer;
            _reader = reader;
        }


        public void Init()
        {
            string[] inParams = _reader.ReadLine().Split(' ');
            int astronautsCount = int.Parse(inParams[0].ToString());
            int countriesCount = int.Parse(inParams[1].ToString());

            //Load astronauts
            List<List<int>> astronauts = new List<List<int>>();
            for (int i = 0; i < countriesCount; i++)
            {
                List<int> countryAstronauts = _reader.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
                List<List<int>> existingPairs = new List<List<int>>();
                countryAstronauts.ForEach(n => {
                    List<int> existingPair = astronauts.SingleOrDefault(p => p.Count(a => a == n) > 0);
                    if (existingPair != null && existingPairs.Count(e=>e==existingPair)==0)
                    {
                        existingPairs.Add(existingPair);
                    }
                });

                if (existingPairs.Count == 0)
                {
                    astronauts.Add(countryAstronauts);
                }
                else if (existingPairs.Count == 1)
                {
                    countryAstronauts.ForEach(n =>
                        {
                            if (existingPairs[0].Count(e => e == n) == 0)
                            {
                                existingPairs[0].Add(n);
                            }
                        });
                }
                else if (existingPairs.Count == 2)
                {
                    existingPairs[0].ForEach(n =>
                    {
                        if (existingPairs[1].Count(e => e == n) == 0)
                        {
                            existingPairs[1].Add(n);
                        }
                    });

                    astronauts.Remove(existingPairs[0]);
                }
            }

            //Test
            //int t = 0;
            //foreach (List<int> ag in astronauts)
            //{
            //    foreach (int a in ag)
            //    {
            //        t++;
            //    }
            //}

            //for (int i = 1; i < astronautsCount; i++)
            //{
            //    int e=0;
            //    foreach (List<int> ag in astronauts)
            //    {
            //        foreach (int a in ag)
            //        {
            //            if (i == a)
            //                e++;
            //        }
            //    }
            //    if (e == 0)
            //    {
            //        int y = 0;
            //    }
            //}

            int pairs = 0;
            for (int i = 0; i < astronauts.Count; i++)
            {
                int index = 0;
                List<List<int>> trimmedPairs = astronauts.Where(ag =>
                {
                    if (index > i)
                    {
                        return true;
                    }
                    index++;
                    return false;
                }).ToList();

                //
                foreach (List<int> countryAstronauts in trimmedPairs)
                {
                    pairs += (countryAstronauts.Count * astronauts[i].Count);
                }
            }
            _writer.WriteLine(pairs.ToString());
        }

        private static void AddRelatedPairs(List<List<int>> astronauts, int[] countryAstronauts, int j, List<int> existingPair)
        {
            List<int> branchedPair = astronauts.SingleOrDefault(ag => ag.Count(a => a == countryAstronauts[j == 0 ? 1 : 0]) > 0);
            if (branchedPair != null)
            {
                foreach (int n in existingPair)
                {
                    branchedPair.Add(n);
                }
            }
            else
            {
                existingPair.Add(countryAstronauts[j == 0 ? 1 : 0]);
            }
        }
    }
}
