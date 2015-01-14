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
                countryAstronauts.ForEach(n =>
                {
                    List<int> existingPair = astronauts.SingleOrDefault(p => p.Count(a => a == n) > 0);
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
                            if (existingPairs[0].Count(e => e == n) == 0)
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
            _writer.WriteLine(pairsCount.ToString());
        }
    }
}
