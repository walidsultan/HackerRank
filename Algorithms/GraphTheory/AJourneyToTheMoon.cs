using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GraphTheory
{
    public class AJourneyToTheMoon
    {
        private IDisplayHandler _console;

        public AJourneyToTheMoon(IDisplayHandler console)
        {
            _console = console;
        }


        public void Init()
        {
            string[] inParams = _console.ReadLine().Split(' ');
            int astronautsCount = int.Parse(inParams[0].ToString());
            int countriesCount = int.Parse(inParams[1].ToString());

            //Load astronauts
            List<List<int>> astronauts = new List<List<int>>();
            for (int i = 0; i < countriesCount; i++)
            {
                List<int> countryAstronauts = _console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
                List<List<int>> existingPairs = new List<List<int>>();
                countryAstronauts.ForEach(n =>
                {
                    List<int> existingPair = astronauts.SingleOrDefault(p => p.IndexOf(n) >= 0);
                    if (existingPair != null && existingPairs.Count(e => e == existingPair) == 0)
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
                            if (existingPairs[0].IndexOf(n) == -1)
                            {
                                existingPairs[0].Add(n);
                            }
                        });
                }
                else if (existingPairs.Count == 2)
                {
                    existingPairs[0].AddRange(existingPairs[1]);
                    astronauts.Remove(existingPairs[1]);
                }
            }

            long pairsCount = 0;
            int rowsCount = astronauts.Count;
            long pairedAstronautsCount = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                pairedAstronautsCount += astronauts[i].Count;
                if (i < rowsCount - 1)
                {
                    pairsCount += pairedAstronautsCount * astronauts[i + 1].Count;
                }
            }
            long singleAstronauts=astronautsCount - pairedAstronautsCount;
            pairsCount += singleAstronauts * pairedAstronautsCount + (singleAstronauts * (singleAstronauts - 1) / 2);
            _console.WriteLine(pairsCount.ToString());
        }
    }
}
