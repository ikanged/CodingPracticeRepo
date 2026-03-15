using System;
using System.Collections.Generic;

namespace CodingPractice.Problems.Interview.BroadwayTech
{
	public class TaskScheduler : AbsProblem, IProblem
	{
        //From Broadway Tech
        
        public TaskScheduler() : base("Topology sort")
		{
           
        }

        public override void Begin()
        {
            
        }

        public bool checkForPair(string input)
        {
            bool status = true;
            int pairCount = 0;
            int tripleCount = 0;

            Dictionary<char, int> data = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (data.ContainsKey(c))
                {
                    data[c]++;
                }
                else
                {
                    data.Add(c, 1);
                }
            }

            //Check for any pairs or triples
            foreach (var kvp in data)
            {
                //  Console.WriteLine($"{kvp.Key} {kvp.Value}");
                if (kvp.Value % 2 == 0 && kvp.Value % 3 != 0)
                {
                    if(pairCount == 0)
                    {
                        if(kvp.Value == 8)
                        {
                            pairCount++;
                            tripleCount += 2;
                            continue;
                        }
                    }
                    var pairs = kvp.Value / 2;
                    // Console.WriteLine("Pairs: " + pairs);
                    pairCount += pairs;
                }
                else if (kvp.Value % 3 == 0)
                {
                    tripleCount++;
                }
                else if (kvp.Value % 3 == 2)
                {
                    pairCount++;
                }                
            }
            // Console.WriteLine("PairCount:" + pairCount);
            // Console.WriteLine(tripleCount);

            if (tripleCount % 3 == 1 && pairCount < 1)
            {
                status = false;
            }
            if (pairCount <= 0)
            {
                status = false;
            }
            if (pairCount > 1)
            {
                status = false;
            }

            return status;
        }
    }
}

