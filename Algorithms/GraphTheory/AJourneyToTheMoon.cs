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
                int[] countryAstronauts = _reader.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

                bool addPair = true;
                for (int j = 0; j < countryAstronauts.Length; j++)
                {
                    List<int> existingPair = astronauts.SingleOrDefault(ag => ag.Count(a => a == countryAstronauts[j]) > 0);
                    if (existingPair != null)
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
                        addPair = false;
                        break;
                    }
                }
                if (addPair)
                {
                    astronauts.Add(countryAstronauts.ToList());
                }
            }

            //Test
            foreach (List<int> ag in astronauts)
            {
                foreach (int a in ag)
                {
                    if (astronauts.Count(agr => agr.Count(ar => ar == a) > 0) > 1)
                    {
                        int t = 0;
                    }
                }
            }

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
    }
}
